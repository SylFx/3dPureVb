Module GDIplus

    Public Sub DrawTriangle(ByVal IndexBuffer_PolygonIndex As Integer, ByVal ColorR As Integer, ByVal ColorG As Integer, ByVal ColorB As Integer, ByVal ColorA As Integer)

        ' Points for drawing polygons

        Dim Point0 As New Point(IndexBuffer_SX0(IndexBuffer_PolygonIndex), IndexBuffer_SY0(IndexBuffer_PolygonIndex))
        Dim Point1 As New Point(IndexBuffer_SX1(IndexBuffer_PolygonIndex), IndexBuffer_SY1(IndexBuffer_PolygonIndex))
        Dim Point2 As New Point(IndexBuffer_SX2(IndexBuffer_PolygonIndex), IndexBuffer_SY2(IndexBuffer_PolygonIndex))

        Dim TrianglePoint As Point() = {Point0, Point1, Point2}

        ' Creating a solid brush

        Dim B As SolidBrush = New SolidBrush(Color.FromArgb(ColorA, ColorR, ColorG, ColorB))

        ' Creating a graphic for our rendering

        Dim Canvas_Graphics As Graphics = Graphics.FromImage(Canvas_Bitmap)

        ' Managing render quality

        If Primitive_RenderMode = Solid Then

            Canvas_Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighSpeed

        End If

        If Primitive_RenderMode = Wireframe Or Primitive_RenderMode = SolidPlusWireframe Or Primitive_RenderMode = SolidHQ Or Primitive_RenderMode = WireframeShowHFace Then

            Canvas_Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

        End If

        ' Solid

        If Primitive_RenderMode = Solid Or Primitive_RenderMode = SolidPlusWireframe Or Primitive_RenderMode = SolidHQ Or Primitive_RenderMode = NoShading Then

            Canvas_Graphics.FillPolygon(B, TrianglePoint)

        End If

        ' Wireframe

        If Primitive_RenderMode = Wireframe Or Primitive_RenderMode = SolidPlusWireframe Or Primitive_RenderMode = SolidHQ Or Primitive_RenderMode = WireframeShowHFace Then

            Dim P As Pen

            If Primitive_RenderMode = SolidPlusWireframe Then

                ColorA = 180
                ColorR = 255
                ColorG = 255
                ColorB = 255
                If ColorR > 255 Then ColorR = 255
                If ColorG > 255 Then ColorG = 255
                If ColorB > 255 Then ColorB = 255

            End If

            P = New Pen(Color.FromArgb(ColorA, ColorR, ColorG, ColorB), 1)
            Canvas_Graphics.DrawPolygon(P, TrianglePoint)

        End If

        Canvas_Graphics.Dispose()

    End Sub

    Public Sub SUB_Text(ByVal X As Single, ByVal Y As Single, ByVal Text As String, Optional ByVal A As Integer = 255, Optional ByVal R As Integer = 255, Optional ByVal G As Integer = 255, Optional ByVal B As Integer = 255)

        ' Text routine used for our on screen infos

        Dim FNT_SIZE As Integer

        ' Font size = 12pix

        FNT_SIZE = 12
        Dim FNT As New Font("Courier New", FNT_SIZE)
        Dim Br As SolidBrush = New SolidBrush(Color.FromArgb(A, R, G, B))

        Canvas_Graphics.DrawString(Text, FNT, Br, X, Y)

    End Sub

End Module
