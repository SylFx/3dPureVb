Module IndexBuffer

    Public Sub IndexBuffer_Init()

        ' Initializing our IndexBuffer

        Triangle_Index = 0
        Total_Vertex = 0
        Visible_Triangle = 0
        Total_Triangle = 0

    End Sub

    Public Sub NewTriangle(ByVal Vertex0 As Integer, ByVal Vertex1 As Integer, ByVal Vertex2 As Integer, ByVal NewMaterial As Integer)

        ' Updating total triangles

        Total_Triangle = Total_Triangle + 1

        ' Some declarations

        Dim Vx0 As Single '                                 Backface culling
        Dim Vy0 As Single
        Dim Vx1 As Single
        Dim Vy1 As Single
        Dim Eq_Result As Single
        Dim IsHidenFace As Boolean '                        Indicate if current face is a hiden one who has to be drawn
        Dim X0, Y0, Z0 As Single '                          Normals calculations
        Dim X1, Y1, Z1 As Single
        Dim NormalX, NormalY, NormalZ As Single
        Dim ShadingValue As Single '                        Exposure value for shading, who is the result of a scalar product (face normal * light normal)
        Dim NM As Single

        IsHidenFace = False

        ' Backface culling: Calculate if face has to be hiden or not. Please note (important!) that vertices of the triangle has to be definied clockwise

        ' Exemple of a triangle with vertex 0, 1, and 2, definied clockwise

        '       0     1
        '       ------
        '       |   /
        '       |  /
        '       | /
        '       |/
        '       2

        Vx0 = SX(Vertex1) - SX(Vertex0)
        Vy0 = SY(Vertex1) - SY(Vertex0)
        Vx1 = SX(Vertex2) - SX(Vertex0)
        Vy1 = SY(Vertex2) - SY(Vertex0)
        Eq_Result = -((Vx0 * Vy1) - (Vx1 * Vy0))

        ' No backface culling with render mode "WireframeShowHFace" or if ShowHidenFace is set to True

        If Primitive_RenderMode = WireframeShowHFace Then ShowHidenFace = True

        ' Backface culling condition

        If ShowHidenFace = False Then
            If Eq_Result >= 0 Then
                Exit Sub '                                  If result is >=0, the triangle is a hiden face and will not be draw. We can exit this procedure...
            End If
        Else
            If Eq_Result >= 0 Then
                IsHidenFace = True '                        ...but, if it is a hidden face who has to be draw (transparent object like our Glenz for exemple), we will continue the process !
            End If
        End If

        IndexBuffer_Material_A(Triangle_Index) = 255 '      Default value for Alpha = 255 (full opacity) 

        If Primitive_RenderMode <> NoShading Then

            ' Calculate the triangle normal

            X0 = X(Vertex1) - X(Vertex0)
            Y0 = Y(Vertex1) - Y(Vertex0)
            Z0 = Z(Vertex1) - Z(Vertex0)

            X1 = X(Vertex2) - X(Vertex0)
            Y1 = Y(Vertex2) - Y(Vertex0)
            Z1 = Z(Vertex2) - Z(Vertex0)

            NormalX = (Y0 * Z1) - (Z0 * Y1)
            NormalY = (Z0 * X1) - (X0 * Z1)
            NormalZ = (X0 * Y1) - (Y0 * X1)

            ' Scaling normal to 1. this is necesary for our further ShadingValue calculation (Light normal is also scaled to 1)

            NM = Math.Sqrt((NormalX ^ 2) + (NormalY ^ 2) + (NormalZ ^ 2))

            NormalX = (NormalX / NM) * 100
            NormalY = (NormalY / NM) * 100
            NormalZ = (NormalZ / NM) * 100

            If ShowHidenFace = True Then

                If IsHidenFace = True Then

                    ' Reverse face normal if triangle is a hiden face who has to be draw

                    NormalX = NormalX * (-1)
                    NormalY = NormalY * (-1)
                    NormalZ = NormalZ * (-1)

                End If

            End If

            ' Main calculculation for shading.

            NM = Math.Sqrt((Light_NormalX ^ 2) + (Light_NormalY ^ 2) + (Light_NormalZ ^ 2))

            Dim LNormalX As Single
            Dim LNormalY As Single
            Dim LNormalZ As Single

            LNormalX = (Light_NormalX / NM) * 100
            LNormalY = (Light_NormalY / NM) * 100
            LNormalZ = (Light_NormalZ / NM) * 100

            ShadingValue = ((LNormalX * NormalX) + (LNormalY * NormalY) + (LNormalZ * NormalZ))

            ' Managing light intensity

            ShadingValue = (-(ShadingValue) / 100) * (Light_Int_Value * 0.01)
            If ShadingValue < 0 Then ShadingValue = 0
            If ShadingValue > 100 Then ShadingValue = 100

        Else

            ShadingValue = 100

        End If

        ' Storing our result in the IndexBuffer

        IndexBuffer_Material(Triangle_Index) = NewMaterial '                                        Material used for each triangle
        IndexBuffer_SX0(Triangle_Index) = SX(Vertex0) '                                             Vertex screen coords of each triangle for rendering to screen
        IndexBuffer_SY0(Triangle_Index) = SY(Vertex0)
        IndexBuffer_SX1(Triangle_Index) = SX(Vertex1)
        IndexBuffer_SY1(Triangle_Index) = SY(Vertex1)
        IndexBuffer_SX2(Triangle_Index) = SX(Vertex2)
        IndexBuffer_SY2(Triangle_Index) = SY(Vertex2)
        IndexBuffer_Material_R(Triangle_Index) = (Material_R(NewMaterial) / 100) * ShadingValue '   Modifying the triangle color depending to its calculated exposure result to the light source
        IndexBuffer_Material_G(Triangle_Index) = (Material_G(NewMaterial) / 100) * ShadingValue
        IndexBuffer_Material_B(Triangle_Index) = (Material_B(NewMaterial) / 100) * ShadingValue
        IndexBuffer_Material_A(Triangle_Index) = Material_A(NewMaterial)
        IndexBuffer_Z(Triangle_Index) = (Z(Vertex0) + Z(Vertex1) + Z(Vertex2)) / 3 '                Calculating the Z position of the triangle with the average Z position of its vertices 

        ' Updating Index and Total triangles

        Triangle_Index = Triangle_Index + 1
        Visible_Triangle = Visible_Triangle + 1

    End Sub

End Module
