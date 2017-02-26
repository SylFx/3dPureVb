Module Render

    Public Sub RenderPrimitive()

        ' For the render, we use a simple method who consist of sorting all calculated triangle with they Z position from the farthest to the nearest, relative to our point of view.
        ' This method is also called "Painter's algorythm".

        Dim TIndex As Integer '                                             Index
        Dim ZBegin As Single '                                              Z sorting begin (the farthest)
        Dim ZEnd As Single '                                                Z sorting end (the nearest)
        Dim ZInterval As Single '                                           Interval (A biger value will increase speed but also decrease the rendering precision)
        Dim ZPos As Integer

        ' Initializing

        ZBegin = 200
        ZEnd = -200
        ZInterval = 25

        ' Clearing the canvas

        Canvas_Graphics.Clear(Form1.Canvas.BackColor)

        ' Z sorting and Rendering

        For ZPos = ZBegin To ZEnd Step -ZInterval

            For TIndex = 0 To Visible_Triangle - 1

                If IndexBuffer_Z(TIndex) > ZPos And IndexBuffer_Z(TIndex) <= ZPos + ZInterval Then

                    ' Call the DrawTriangle procedure

                    DrawTriangle(TIndex, IndexBuffer_Material_R(TIndex), IndexBuffer_Material_G(TIndex), IndexBuffer_Material_B(TIndex), IndexBuffer_Material_A(TIndex))

                End If

            Next

        Next

        ' On screen infos

        Dim TX As Integer = Form1.Canvas.Width - 320
        Dim TY As Integer = 10
        Dim A, R, G, B As Integer

        If Primitive_RenderMode = Wireframe Or Primitive_RenderMode = WireframeShowHFace Then

            A = 200
            R = 200
            G = 200
            B = 200

        Else

            A = 200
            R = 46
            G = 48
            B = 50

        End If

        Update_Light()
        SUB_Text(TX, TY, "3dPureVb ", A, R, G, B)
        SUB_Text(TX, TY + 40, "Primitive:", A, R, G, B) : SUB_Text(TX + 150, TY + 40, " " + Primitive_Name(Primitive_Type), A, R, G, B)
        SUB_Text(TX, TY + 60, "Vertices:", A, R, G, B) : SUB_Text(TX + 150, TY + 60, Str(Total_Vertex), A, R, G, B)
        SUB_Text(TX, TY + 80, "Triangles:", A, R, G, B) : SUB_Text(TX + 150, TY + 80, Str(Total_Triangle), A, R, G, B)
        SUB_Text(TX, TY + 100, "Visibles tri:", A, R, G, B) : SUB_Text(TX + 150, TY + 100, Str(Visible_Triangle), A, R, G, B)
        SUB_Text(TX, TY + 120, "Position:", A, R, G, B) : SUB_Text(TX + 150, TY + 120, Str(Int(Primitive_XPos)) + "," + Str(Int(Primitive_YPos)) + "," + Str(Int(Primitive_ZPos)), A, R, G, B)
        SUB_Text(TX, TY + 140, "Rotation:", A, R, G, B) : SUB_Text(TX + 150, TY + 140, Str(Int(Primitive_XAngle)) + "," + Str(Int(Primitive_YAngle)) + "," + Str(Int(Primitive_ZAngle)), A, R, G, B)
        SUB_Text(TX, TY + 160, "Zoom:", A, R, G, B) : SUB_Text(TX + 150, TY + 160, Str(Math.Round(Zoom, 2)), A, R, G, B)
        SUB_Text(TX, TY + 180, "Perspective:", A, R, G, B) : SUB_Text(TX + 150, TY + 180, Str(Math.Round(Perspective, 4)), A, R, G, B)
        SUB_Text(TX, TY + 200, "Dir-Light:", A, R, G, B) : SUB_Text(TX + 150, TY + 200, Str(Light_NormalX) + "," + Str(Light_NormalY) + "," + Str(Light_NormalZ) + "," + Str(Light_Int_Value) + "%", A, R, G, B)

        ' Updating the canvas

        Form1.Canvas.Refresh()

    End Sub

End Module
