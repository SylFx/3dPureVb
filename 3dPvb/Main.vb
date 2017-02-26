Module Main

    Sub Init3d()

        Update_Light() '                                                    Initialise lighting

        Perspective = 0.004 '                                               Initialise perspective
        Zoom = 1 '                                                          Initialise Zoom
        Form1.Canvas.BackColor = InitBackColor

        NewMaterial(1, 255, 128, 128, 255) '                                Creating some materials
        NewMaterial(2, 255, 255, 0, 255)
        NewMaterial(3, 255, 0, 255, 180)
        NewMaterial(4, 255, 0, 180, 255)
        NewMaterial(5, 255, 255, 128, 0)
        NewMaterial(6, 255, 255, 255, 255)
        NewMaterial(7, 255, 0, 64, 128)
        NewMaterial(8, 255, 0, 230, 255)
        NewMaterial(9, 180, 200, 0, 200)
        NewMaterial(10, 230, 255, 200, 255)
        NewMaterial(11, 255, 193, 233, 112)
        NewMaterial(12, 255, 73, 116, 1)
        NewMaterial(13, 255, 255, 255, 255)
        NewMaterial(14, 255, 255, 0, 255)
        NewMaterial(15, 255, 255, 200, 128)
        NewMaterial(16, 255, 64, 64, 128)

        Primitive_Name(Cube) = "Cube" '                                     Will be used for primitive type identification (on screen infos)
        Primitive_Name(Cylinder) = "Cylinder"
        Primitive_Name(Sphere) = "Sphere"
        Primitive_Name(Glenz) = "Glenz"
        Primitive_Name(Torus) = "Torus"
        Primitive_Name(Spiral) = "Spiral"

        Primitive_Type = Cube '                                             Default values when starting
        Primitive_RenderMode = Solid
        Primitive_XPos = 0
        Primitive_YPos = 0
        Primitive_ZPos = 0
        Primitive_XAngle = 0
        Primitive_YAngle = 0
        Primitive_ZAngle = 0
        InitBackColor = Form1.Canvas.BackColor
        WfBackColor = Color.FromArgb(255, 46, 48, 50)

    End Sub

    Sub Update_Light()

        ' light update

        Light_NormalX = Val(Form1.UI_Lightsource_LightX.Text) '             Dir vector X
        Light_NormalY = Val(Form1.UI_Lightsource_LightY.Text) '             Dir vector Y
        Light_NormalZ = Val(Form1.UI_Lightsource_LightZ.Text) '             Dir vector Z
        Light_Int_Value = Val(Form1.UI_Lightsource_LightIntensity.Text) '   intensity

    End Sub

    Sub Main3d()

        ' Initialise IndexBuffer

        IndexBuffer_Init()

        ' Primitives creation

        If Primitive_Type = Cube Then NewMesh_Cube()
        If Primitive_Type = Cylinder Then NewMesh_Cylinder()
        If Primitive_Type = Sphere Then NewMesh_Sphere()
        If Primitive_Type = Torus Then NewMesh_Torus()
        If Primitive_Type = Glenz Then NewMesh_Glenz()
        If Primitive_Type = Spiral Then NewMesh_Spiral()

        ' Rendering

        RenderPrimitive()

    End Sub


    Public Sub NewVertex(ByVal Vertex_Index As Integer, ByVal Vertex_X As Single, ByVal Vertex_Y As Single, ByVal Vertex_Z As Single)

        ' Creating a new vertex

        X(Vertex_Index) = Vertex_X
        Y(Vertex_Index) = Vertex_Y
        Z(Vertex_Index) = Vertex_Z

        ' 3d Transformation

        Rotate(Vertex_Index, Primitive_XAngle, Primitive_YAngle, Primitive_ZAngle)
        Move(Vertex_Index, Primitive_XPos, Primitive_YPos, Primitive_ZPos)

        ' rasterization (converting 3d coords in space into 2d coords for rendering on screen)

        SX(Vertex_Index) = Canvas_CenterX + ((X(Vertex_Index) / (Perspective * Z(Vertex_Index) + 1)) * Zoom)
        SY(Vertex_Index) = Canvas_CenterY + ((-Y(Vertex_Index) / (Perspective * Z(Vertex_Index) + 1)) * Zoom)

        Total_Vertex = Total_Vertex + 1

    End Sub

    Public Sub NewMaterial(ByVal MatIndex As Integer, ByVal A As Integer, ByVal R As Integer, ByVal G As Integer, ByVal B As Integer)

        ' Material color (A, R, G, B)

        Material_A(MatIndex) = A '                                          Alpha (transparency)
        Material_R(MatIndex) = R '                                          Red
        Material_G(MatIndex) = G '                                          Green
        Material_B(MatIndex) = B '                                          Blue

    End Sub

    Public Sub PrimitiveAngle(ByVal Index As Integer, ByVal X As Single, ByVal Y As Single, ByVal Z As Single)

        ' Primitive rotation

        Primitive_XAngle = X
        Primitive_YAngle = Y
        Primitive_ZAngle = Z

    End Sub

    Public Sub PrimitivePosition(ByVal Index As Integer, ByVal X As Single, ByVal Y As Single, ByVal Z As Single)

        ' Primitive position

        Primitive_XPos = X
        Primitive_YPos = Y
        Primitive_ZPos = Z

    End Sub

End Module
