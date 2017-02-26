Module Init

    '         3 d P v b ( 3dPureVb)
    '                       V 1 . 3
    ' (C) 2013 - 2017 Sylvain SIMON
    '                 www.sylfx.net
    '          www.github.com/sylfx

    ' Main 

    Public Const Pi = 3.14159265358979 '                            Value of Pi
    Public Const CDeg = Pi / 180 '                                  Conversion RAD. to DEG.
    Public Perspective As Single '                                  Perspective
    Public Zoom As Single '                                         Zoom
    Public InitBackColor As Color '                                 Canvas backcolor at startup in solid mode
    Public WfBackColor As Color '                                   Canvas backcolor in wireframe mode
    Public Const Cube = 1 '                                         Primitive type
    Public Const Cylinder = 2
    Public Const Sphere = 3
    Public Const Torus = 4
    Public Const Spiral = 5
    Public Const Glenz = 6

    ' Canvas

    Public Canvas_Bitmap As Bitmap '                                For the creation of a bitmap (rendering surface)
    Public Canvas_Graphics As Graphics '                            For our graphic rendering
    Public Canvas_CenterX As Integer '                              Center of the render surface (picture box)
    Public Canvas_CenterY As Integer

    ' User mouse actions 

    Public UserMode As Integer
    Public Const DemoMode As Integer = 0
    Public Const User_MovePrimitive As Integer = 1
    Public Const User_RotatePrimitive As Integer = 2
    Public Const User_Perspective As Integer = 3
    Public Const User_Zoom As Integer = 4
    Public Mouse_InitX As Single
    Public Mouse_InitY As Single
    Public Mouse_X As Single
    Public Mouse_Y As Single
    Public Mouse_Button As Integer

    ' For the demo mode 

    Public DemoTime As Integer
    Public DemoA As Integer
    Public DemoD As Integer
    Public DemoP As Integer
    Public DemoR As Integer
    Public Init_Primitive_Type As Integer
    Public Init_Primitive_RenderMode As Integer
    Public Init_Primitive_XPos As Single
    Public Init_Primitive_YPos As Single
    Public Init_Primitive_ZPos As Single
    Public Init_Primitive_XAngle As Single
    Public Init_Primitive_YAngle As Single
    Public Init_Primitive_ZAngle As Single
    Public Init_Zoom As Single
    Public Init_Perspective As Single
    Public Init_Backcolor As Color

    ' Primitives managment

    Public Primitive_Type As Integer '                              Primitive type
    Public Primitive_Name(8) As String '                            Primitive name
    Public Primitive_RenderMode As Integer
    Public Primitive_XPos As Single '                               Position
    Public Primitive_YPos As Single
    Public Primitive_ZPos As Single
    Public Primitive_XAngle As Single '                             Rotation
    Public Primitive_YAngle As Single
    Public Primitive_ZAngle As Single

    ' Primitives meshes creation

    Public Const Maxnum_Vertex = 2048 '                             Max number of vertex
    Public Const Maxnum_Triangle = 2048 '                           Max number of triangles (polygons)
    Public Total_Vertex As Integer '                                Vertex count
    Public Total_Triangle As Integer '                              Triangles count
    Public Visible_Triangle As Integer '                            Visibles triangles count
    Public Triangle_Index As Integer '                              Triangle index
    Public X(Maxnum_Vertex) As Single '                             Vertex 3d coords (X, Y, Z)
    Public Y(Maxnum_Vertex) As Single
    Public Z(Maxnum_Vertex) As Single
    Public SX(Maxnum_Vertex) As Single '                            Vertex 2d coords (X, Y)
    Public SY(Maxnum_Vertex) As Single

    ' Render / Materials 

    Public Const Wireframe = 0 '                                    Wireframe
    Public Const Solid = 1 '                                        Solid
    Public Const SolidHQ = 2 '                                      Solid HQ (antialias)
    Public Const SolidPlusWireframe = 3 '                           Solid + wireframe
    Public Const WireframeShowHFace = 4 '                           Wireframe with backfaces
    Public Const NoShading = 5 '                                    NoShading (Solid without shading)
    Public ShowHidenFace As Boolean '                               Disable backface culling and show hiden faces (can be useful for transparent object, see Glenz for exemple)
    Public Material_R(32) As Integer '                              Materials R, G, B A components (Red, Green, Blue, Alpha)
    Public Material_G(32) As Integer
    Public Material_B(32) As Integer
    Public Material_A(32) As Integer

    ' Lighting 

    Public Light_NormalX As Single '                                Lighting vector (Note: light type in our 3d engine is a directional light)
    Public Light_NormalY As Single
    Public Light_NormalZ As Single
    Public Light_Int_Value As Single '                              Light intensity

    ' IndexBuffer 

    Public IndexBuffer_Index(Maxnum_Triangle) '                     Triangle index
    Public IndexBuffer_Material(Maxnum_Triangle) As Integer '       Material index
    Public IndexBuffer_Material_R(Maxnum_Triangle) '                RGBA values of the triangles
    Public IndexBuffer_Material_G(Maxnum_Triangle)
    Public IndexBuffer_Material_B(Maxnum_Triangle)
    Public IndexBuffer_Material_A(Maxnum_Triangle)
    Public IndexBuffer_SX0(Maxnum_Triangle) As Integer '            2d screen coords of each triangles vertex
    Public IndexBuffer_SY0(Maxnum_Triangle) As Integer
    Public IndexBuffer_SX1(Maxnum_Triangle) As Integer
    Public IndexBuffer_SY1(Maxnum_Triangle) As Integer
    Public IndexBuffer_SX2(Maxnum_Triangle) As Integer
    Public IndexBuffer_SY2(Maxnum_Triangle) As Integer
    Public IndexBuffer_Z(Maxnum_Triangle) As Single '               Triangles Z position (used for Z sorting)

End Module