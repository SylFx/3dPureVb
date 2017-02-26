Module Geometry

    Public Sub NewMesh_Cube()

        ' Vertices

        NewVertex(0, -100, 100, -100)
        NewVertex(1, 100, 100, -100)
        NewVertex(2, 100, 100, 100)
        NewVertex(3, -100, 100, 100)
        NewVertex(4, -100, -100, -100)
        NewVertex(5, 100, -100, -100)
        NewVertex(6, 100, -100, 100)
        NewVertex(7, -100, -100, 100)

        ' Triangles

        NewTriangle(0, 1, 4, 15)
        NewTriangle(5, 4, 1, 1)
        NewTriangle(1, 2, 5, 1)
        NewTriangle(6, 5, 2, 16)
        NewTriangle(2, 7, 6, 16)
        NewTriangle(3, 7, 2, 1)
        NewTriangle(3, 0, 4, 15)
        NewTriangle(7, 3, 4, 1)
        NewTriangle(0, 3, 1, 15)
        NewTriangle(2, 1, 3, 1)
        NewTriangle(4, 5, 7, 1)
        NewTriangle(6, 7, 5, 16)

    End Sub

    Public Sub NewMesh_Cylinder()

        ' Declarations

        Dim U, UA, i As Integer
        Dim URay As Single
        Dim M, IM As Integer
        Const PrimURes = 12

        ' Initializing

        U = 360 / PrimURes
        URay = 100
        IM = 13

        ' Vertices

        NewVertex(0, 0, URay, 0)

        i = 1

        For UA = 0 To 0 + 359 Step U

            NewVertex(i, 0 - URay * Math.Cos(UA * CDeg), URay, 0 - URay * Math.Sin(UA * CDeg))
            i = i + 1

        Next

        For UA = 0 To 0 + 359 Step U

            NewVertex(i, 0 - URay * Math.Cos(UA * CDeg), -URay, 0 - URay * Math.Sin(UA * CDeg))
            i = i + 1

        Next

        NewVertex(i, 0, -URay, 0)

        ' Triangles

        M = IM
        i = 1

        For U = 1 To PrimURes

            If U < PrimURes Then

                NewTriangle(i, i + 1, i + PrimURes, M)
                NewTriangle(i + 1, i + PrimURes + 1, i + PrimURes, M)
                NewTriangle(0, i + 1, i, M)
                NewTriangle(i + PrimURes, i + PrimURes + 1, (PrimURes * 2) + 1, M)

            End If

            If U = PrimURes Then

                NewTriangle(i, i - PrimURes + 1, i + PrimURes, M)
                NewTriangle(i - PrimURes + 1, i + 1, i + PrimURes, M)
                NewTriangle(0, i - PrimURes + 1, i, M)
                NewTriangle(i + PrimURes, i + 1, (PrimURes * 2) + 1, M)

            End If

            M = M + 1 : If M > 14 Then M = 13
            i = i + 1

        Next U

    End Sub

    Public Sub NewMesh_Sphere()

        ' Declarations

        Dim U, V, i, UA, VA, VSeg As Integer
        Dim URay As Single
        Dim M, IM As Integer

        ' UV resolution

        Const PrimURes = 12
        Const PrimVRes = 12

        ' Intializing

        U = 360 / PrimURes
        V = 180 / PrimVRes

        VA = 90 + V

        ' Vertices

        NewVertex(0, 0, 100, 0)

        i = 1

        For VSeg = 1 To PrimVRes - 1 Step 1

            URay = 0 + 100 * Math.Cos(VA * CDeg)

            For UA = 0 To 0 + 359 Step U

                NewVertex(i, 0 + URay * Math.Cos(UA * CDeg), 0 + 100 * Math.Sin(VA * CDeg), 0 + URay * Math.Sin(UA * CDeg))
                i = i + 1

            Next

            VA = VA + V

        Next VSeg

        NewVertex(i, 0, -100, 0)

        ' Triangles

        i = 1
        IM = 5

        For V = 1 To PrimVRes

            M = IM

            If V = 1 Then

                For U = 1 To PrimURes

                    If U < PrimURes Then NewTriangle(0, i + 1, i, M)
                    If U = PrimURes Then NewTriangle(0, i - PrimURes + 1, i, M)
                    M = M + 1 : If M > 6 Then M = 5
                    i = i + 1

                Next U

            End If

            If V > 1 And V < PrimVRes Then

                For U = 1 To PrimURes

                    If U < PrimURes Then

                        NewTriangle(i - PrimURes, i - PrimURes + 1, i, M)
                        NewTriangle(i - PrimURes + 1, i + 1, i, M)

                    End If

                    If U = PrimURes Then

                        NewTriangle(i - PrimURes, i - ((PrimURes * 2) - 1), i, M)
                        NewTriangle(i - PrimURes + 1, i, i - ((PrimURes * 2)) + 1, M)

                    End If

                    M = M + 1 : If M > 6 Then M = 5
                    i = i + 1

                Next U

            End If

            If V = PrimVRes Then

                For U = 1 To PrimURes

                    If U < PrimURes Then NewTriangle((PrimURes * (PrimVRes - 1)) + 1, i - PrimURes, i - PrimURes + 1, M)
                    If U = PrimURes Then NewTriangle((PrimURes * (PrimVRes - 1)) + 1, i - PrimURes, i - (PrimURes * 2) + 1, M)

                    M = M + 1 : If M > 6 Then M = 5
                    i = i + 1

                Next U

            End If

            IM = IM + 1 : If IM > 6 Then IM = 5

        Next V

    End Sub

    Public Sub NewMesh_Torus()

        ' Declarations

        Dim U, V, i, UA, VA, VSeg As Integer
        Dim URay As Single
        Dim M, IM As Integer
        Const TorusInRadius = 30

        ' UV resolution

        Const PrimURes = 12
        Const PrimVRes = 12

        ' Initializing

        U = 360 / PrimURes
        V = 360 / PrimVRes

        VA = 0

        ' Vertices

        i = 0

        For VSeg = 1 To PrimVRes + 1 Step 1

            URay = (100 - TorusInRadius) - (0 + TorusInRadius * Math.Cos((VA) * CDeg))

            For UA = 0 To 0 + 359 Step U

                NewVertex(i, 0 + URay * Math.Cos(UA * CDeg), 0 + TorusInRadius * Math.Sin(VA * CDeg), 0 + URay * Math.Sin(UA * CDeg))
                i = i + 1

            Next

            VA = VA + V

        Next VSeg

        ' Triangles

        i = 0
        IM = 7

        For V = 1 To PrimVRes

            M = IM

            For U = 1 To PrimURes

                If U < PrimURes Then

                    NewTriangle(i, i + 1, i + PrimURes, M)
                    NewTriangle(i + 1, i + PrimURes + 1, i + PrimURes, M)

                End If

                If U = PrimURes Then

                    NewTriangle(i, i - PrimURes + 1, i + PrimURes, M)
                    NewTriangle(i - PrimURes + 1, i + 1, i + PrimURes, M)

                End If

                M = M + 1 : If M > 8 Then M = 7
                i = i + 1

            Next U

            IM = IM + 1 : If IM > 8 Then IM = 7

        Next V

    End Sub

    Public Sub NewMesh_Glenz()

        ' ***** This object just makes me remember the good old Amiga time, and is a friendly dedication to the Demoscene :) *****

        ' Vertices

        NewVertex(1, -80, 80, -80)
        NewVertex(2, 80, 80, -80)
        NewVertex(3, 80, 80, 80)
        NewVertex(4, -80, 80, 80)
        NewVertex(5, -80, -80, -80)
        NewVertex(6, 80, -80, -80)
        NewVertex(7, 80, -80, 80)
        NewVertex(8, -80, -80, 80)
        NewVertex(9, -125, 0, 0)
        NewVertex(10, 125, 0, 0)
        NewVertex(11, 0, 125, 0)
        NewVertex(12, 0, -125, 0)
        NewVertex(13, 0, 0, -125)
        NewVertex(14, 0, 0, 125)

        ' Triangles

        NewTriangle(1, 2, 13, 10)
        NewTriangle(2, 6, 13, 9)
        NewTriangle(6, 5, 13, 10)
        NewTriangle(5, 1, 13, 9)
        NewTriangle(2, 3, 10, 9)
        NewTriangle(3, 7, 10, 10)
        NewTriangle(7, 6, 10, 9)
        NewTriangle(6, 2, 10, 10)
        NewTriangle(3, 4, 14, 10)
        NewTriangle(4, 8, 14, 9)
        NewTriangle(8, 7, 14, 10)
        NewTriangle(7, 3, 14, 9)
        NewTriangle(4, 1, 9, 9)
        NewTriangle(1, 5, 9, 10)
        NewTriangle(5, 8, 9, 9)
        NewTriangle(8, 4, 9, 10)
        NewTriangle(2, 1, 11, 9)
        NewTriangle(3, 2, 11, 10)
        NewTriangle(4, 3, 11, 9)
        NewTriangle(1, 4, 11, 10)
        NewTriangle(5, 6, 12, 9)
        NewTriangle(6, 7, 12, 10)
        NewTriangle(7, 8, 12, 9)
        NewTriangle(8, 5, 12, 10)

    End Sub

    Public Sub NewMesh_Spiral()

        ' Declarations

        Dim U, V, i, UA, VA, VSeg As Integer
        Dim URay As Single
        Dim M, IM As Integer
        Dim U1 As Single
        Const SpiralInRadius = 45

        ' UV Resolution

        Const PrimURes = 24
        Const PrimVRes = 12

        ' Initialisation

        U = 720 / PrimURes
        V = 360 / PrimVRes
        VA = 0

        ' Vertices

        NewVertex(0, 0 + (100 - SpiralInRadius) * Math.Cos(0 * CDeg), 100, 0 + (100 - SpiralInRadius) * Math.Sin(0 * CDeg))

        i = 1

        For VSeg = 1 To PrimVRes + 1 Step 1

            URay = (100 - SpiralInRadius) - (0 + SpiralInRadius * Math.Cos((VA) * CDeg))

            U1 = 100

            For UA = 0 To 0 + 719 Step U

                NewVertex(i, 0 + URay * Math.Cos(UA * CDeg), U1 + SpiralInRadius * Math.Sin(VA * CDeg), 0 + URay * Math.Sin(UA * CDeg))
                U1 = U1 - 10
                i = i + 1

            Next

            VA = VA + V

        Next VSeg

        NewVertex(i, 0 + (100 - SpiralInRadius) * Math.Cos((0 - U) * CDeg), U1 + 10, 0 + (100 - SpiralInRadius) * Math.Sin((0 - U) * CDeg))

        ' Triangles

        i = 1
        IM = 11

        For V = 1 To PrimVRes

            M = IM

            For U = 1 To PrimURes

                If U < PrimURes Then

                    NewTriangle(i, i + 1, i + PrimURes, M)
                    NewTriangle(i + 1, i + PrimURes + 1, i + PrimURes, M)

                End If

                M = M + 1 : If M > 12 Then M = 11
                i = i + 1

            Next U

            IM = IM + 1 : If IM > 12 Then IM = 11

        Next V

        i = 1
        M = 11

        For V = 0 To PrimVRes - 1

            NewTriangle(0, i, i + PrimURes, M)
            NewTriangle((PrimURes * (PrimVRes + 1)) + 1, i + PrimURes - 1 + PrimURes, i + PrimURes - 1, M)
            i = i + PrimURes

        Next V

    End Sub

End Module
