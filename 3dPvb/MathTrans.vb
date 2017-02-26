Module MathTrans

    Public Sub Move(ByVal Vertex As Integer, ByVal XMove As Single, ByVal YMove As Single, ByVal ZMove As Single)

        ' Translation

        X(Vertex) = X(Vertex) + XMove
        Y(Vertex) = Y(Vertex) + YMove
        Z(Vertex) = Z(Vertex) + ZMove

    End Sub

    Public Sub Rotate(ByVal Vertex As Integer, ByVal XRot As Single, ByVal YRot As Single, ByVal ZRot As Single)

        ' Rotation

        Dim X_1, Y_1, Z_1 As Single
        Dim X_2, Y_2, Z_2 As Single

        X_1 = X(Vertex)
        Y_1 = Y(Vertex) * (Math.Cos(XRot * CDeg)) - Z(Vertex) * (Math.Sin(XRot * CDeg))
        Z_1 = Z(Vertex) * (Math.Cos(XRot * CDeg)) + Y(Vertex) * (Math.Sin(XRot * CDeg))

        X_2 = X_1 * (Math.Cos(YRot * CDeg)) - Z_1 * (Math.Sin(YRot * CDeg))
        Y_2 = Y_1
        Z_2 = Z_1 * (Math.Cos(YRot * CDeg)) + X_1 * (Math.Sin(YRot * CDeg))

        X(Vertex) = (X_2 * (Math.Cos(ZRot * CDeg)) - Y_2 * (Math.Sin(ZRot * CDeg)))
        Y(Vertex) = (Y_2 * (Math.Cos(ZRot * CDeg)) + X_2 * (Math.Sin(ZRot * CDeg)))
        Z(Vertex) = (Z_2)

    End Sub

    '

    Public Sub TestAngle()

        ' Here we will test our angles and eventualy re-calculate them so they always have a value betwen 0 and 359 (Necessary for on screen infos)

        Dim d As Single

        ' X

        If Primitive_XAngle < 0 Then

            d = Primitive_XAngle
            Primitive_XAngle = 359 + d

        End If

        If Primitive_XAngle > 359 Then

            d = Primitive_XAngle - 359
            Primitive_XAngle = 0 + d

        End If

        ' Y

        If Primitive_YAngle < 0 Then

            d = Primitive_YAngle
            Primitive_YAngle = 359 + d

        End If

        If Primitive_YAngle > 359 Then

            d = Primitive_YAngle - 359
            Primitive_YAngle = 0 + d

        End If

        ' Z

        If Primitive_ZAngle < 0 Then

            d = Primitive_ZAngle
            Primitive_ZAngle = 359 + d

        End If

        If Primitive_ZAngle > 359 Then

            d = Primitive_ZAngle - 359
            Primitive_ZAngle = 0 + d

        End If

    End Sub

End Module
