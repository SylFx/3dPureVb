Public Class Form1

    Inherits System.Windows.Forms.Form

    Public MO_Color As Color '                                              Mouse-over color (having some visuals on the UI...)
    Public ML_Color As Color '                                              Mouse-leave color

    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Show() '                                                         Show the windows form
        InitBackColor = Me.Canvas.BackColor '                               Init canvas backcolor
        MO_Color = Color.FromArgb(255, 120, 140, 240) '                     Mouse-over Color
        ML_Color = UI_Main_UserMode.ForeColor '                             Mouse-leave Color
        Init3d() '                                                          Initialize our 3d engine
        UI_ShowMainPanel() '                                                Init main control panel
        Start_DemoMode() '                                                  Starting project in demo-mode

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        UpdateCanvas()
        Me.Panel_MainMenu.Height = Me.Canvas.Height
        Me.Panel_About.Height = Me.Canvas.Height
        Me.Panel_Primitive.Height = Me.Canvas.Height
        Me.Panel_Light.Height = Me.Canvas.Height
        Me.Panel_Render.Height = Me.Canvas.Height

    End Sub

    Private Sub Canvas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Canvas.MouseDown

        UI_InitPanels()
        Mouse_InitX = e.X
        Mouse_InitY = e.Y

    End Sub

    Private Sub Canvas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Canvas.MouseMove

        If UserMode = DemoMode Then Exit Sub

        ' Declaration

        Dim PX As Single
        Dim PY As Single
        Dim PZ As Single

        ' Initializing

        Mouse_X = e.X
        Mouse_Y = e.Y
        Mouse_Button = e.Button

        ' Managing user mouse action

        If UserMode = User_MovePrimitive Then

            ' Moving primitive

            If Mouse_Button = Windows.Forms.MouseButtons.Left Then

                PX = Mouse_X - Mouse_InitX
                PY = Mouse_Y - Mouse_InitY

            End If

            If Mouse_Button = Windows.Forms.MouseButtons.Right Then

                PZ = Mouse_Y - Mouse_InitY

            End If

            ' Updating primitive position

            Primitive_XPos = Primitive_XPos + PX
            Primitive_YPos = Primitive_YPos - PY
            Primitive_ZPos = Primitive_ZPos + PZ

        End If

        If UserMode = User_RotatePrimitive Then

            ' Rotating primitive

            If Mouse_Button = Windows.Forms.MouseButtons.Left Then

                PX = Mouse_X - Mouse_InitX
                PY = Mouse_Y - Mouse_InitY

            End If

            If Mouse_Button = Windows.Forms.MouseButtons.Right Then

                PZ = Mouse_X - Mouse_InitX

            End If

            ' Updating primitive angle

            Primitive_XAngle = Primitive_XAngle - PY
            Primitive_YAngle = Primitive_YAngle + PX
            Primitive_ZAngle = Primitive_ZAngle + PZ

        End If

        If UserMode = User_Perspective Then

            ' Modifying perspective

            If Mouse_Button = Windows.Forms.MouseButtons.Left Then

                PX = (Mouse_X - Mouse_InitX) * 0.00001

            End If

            ' Updating

            Perspective = Perspective + PX
            If Perspective < 0.001 Then Perspective = 0.001
            If Perspective > 0.007 Then Perspective = 0.007

        End If

        If UserMode = User_Zoom Then

            ' Modifying zoom

            If Mouse_Button = Windows.Forms.MouseButtons.Left Then

                PX = (Mouse_X - Mouse_InitX) * 0.005

            End If

            ' Updating

            Zoom = Zoom + PX
            If Zoom < 0.01 Then Zoom = 0.01
            If Zoom > 5 Then Zoom = 5

        End If

        Mouse_InitX = Mouse_X
        Mouse_InitY = Mouse_Y

        ' Calling the TestAngle procedure to recalculate angles if they are <0 or >359 (necessary for our on-screen infos)

        TestAngle()

        ' Updating 3d engine

        Main3d()

    End Sub

    Private Sub UpdateCanvas()

        If Me.Panel_MainMenu.Visible = True Then

            Me.Canvas.Left = 0 + Me.Sylfx3dPureVb_SideImage.Width + Me.Panel_MainMenu.Width
            Me.Canvas.Width = Me.Width - Me.Panel_MainMenu.Width - Me.Sylfx3dPureVb_SideImage.Width
            Me.Canvas.Height = Me.Height - 20

        Else

            Me.Canvas.Left = 0
            Me.Canvas.Width = Me.Width
            Me.Canvas.Height = Me.Height - 20

        End If

        Me.Canvas.Top = 0

        ' Updating render canvas if window is resized

        Canvas_CenterX = Me.Canvas.Width / 2
        Canvas_CenterY = Me.Canvas.Height / 2

        ' Creating a Bitmap surface

        Canvas_Bitmap = New Bitmap(Me.Canvas.ClientSize.Width, Me.Canvas.ClientSize.Height)
        Me.Canvas.Image = Canvas_Bitmap
        Canvas_Graphics = Graphics.FromImage(Canvas_Bitmap)
        Me.Canvas.Refresh()

    End Sub

    Public Sub UI_InitPanels()

        ' Initialize UI

        Panel_Primitive.Visible = False
        Panel_Primitive.Enabled = False
        Panel_Light.Visible = False
        Panel_Light.Enabled = False
        Panel_Render.Visible = False
        Panel_Render.Enabled = False
        Panel_About.Visible = False
        Panel_About.Enabled = False

    End Sub

    Private Sub UI_HideMainPanel()

        Panel_MainMenu.Visible = False
        Panel_MainMenu.Enabled = False
        UpdateCanvas()

    End Sub

    Private Sub UI_ShowMainPanel()

        Panel_MainMenu.Location = New Point(Sylfx3dPureVb_SideImage.Width, -1)
        Panel_MainMenu.Visible = True
        Panel_MainMenu.Enabled = True
        Panel_MainMenu.BringToFront()
        Sylfx3dPureVb_SideImage.Visible = True
        Sylfx3dPureVb_SideImage.Enabled = True
        Sylfx3dPureVb_SideImage.BringToFront()
        UpdateCanvas()

    End Sub

    Private Sub UI_ShowPrimitivePanel()

        Panel_Primitive.BringToFront()
        Panel_Primitive.Location = New Point(Sylfx3dPureVb_SideImage.Width + Panel_MainMenu.Width - 1, -1)
        Panel_Primitive.Visible = True
        Panel_Primitive.Enabled = True
        Panel_Primitive.BringToFront()

    End Sub

    Private Sub UI_ShowLightPanel()

        Panel_Light.Location = New Point(Sylfx3dPureVb_SideImage.Width + Panel_MainMenu.Width - 1, -1)
        Panel_Light.Visible = True
        Panel_Light.Enabled = True
        Panel_Light.BringToFront()

    End Sub

    Private Sub UI_ShowRenderPanel()

        Panel_Render.Location = New Point(Sylfx3dPureVb_SideImage.Width + Panel_MainMenu.Width - 1, -1)
        Panel_Render.Visible = True
        Panel_Render.Enabled = True
        Panel_Render.BringToFront()

    End Sub

    Private Sub UI_ShowAboutPanel()

        Panel_About.BringToFront()
        Panel_About.Location = New Point(Sylfx3dPureVb_SideImage.Width, -1)
        Panel_About.Visible = True
        Panel_About.Enabled = True
        Panel_About.BringToFront()
        Sylfx3dPureVb_SideImage.Visible = True
        Sylfx3dPureVb_SideImage.Enabled = True
        Sylfx3dPureVb_SideImage.BringToFront()

    End Sub

    Private Sub UI_Main_Hide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Main_Hide.Click

        UI_InitPanels()
        UI_HideMainPanel()

    End Sub

    Private Sub UI_Main_Hide_mouseenter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Main_Hide.MouseEnter

        ML_Color = UI_Main_Hide.ForeColor
        UI_Main_Hide.ForeColor = MO_Color

    End Sub

    Private Sub UI_Main_Hide_mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Main_Hide.MouseLeave
        UI_Main_Hide.ForeColor = ML_Color
    End Sub

    Private Sub UI_Main_Quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Main_Quit.Click

        UI_InitPanels()
        Application.Exit()
        End

    End Sub

    Private Sub UI_Main_Quit_mouseenter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Main_Quit.MouseEnter

        ML_Color = UI_Main_Quit.ForeColor
        UI_Main_Quit.ForeColor = MO_Color

    End Sub

    Private Sub UI_Main_Quit_mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Main_Quit.MouseLeave

        UI_Main_Quit.ForeColor = ML_Color

    End Sub

    Private Sub Panel_MainMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel_MainMenu.Click

        UI_InitPanels()

    End Sub

    Private Sub UI_Main_PrimType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Main_PrimType.Click

        UI_InitPanels()
        UI_ShowPrimitivePanel()

        If UserMode = DemoMode Then

            End_DemoMode()
            Main3d()

        End If

    End Sub

    Private Sub UI_Main_PrimType_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Main_PrimType.MouseEnter

        ML_Color = UI_Main_PrimType.ForeColor
        UI_Main_PrimType.ForeColor = MO_Color

    End Sub

    Private Sub UI_Main_PrimType_Mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Main_PrimType.MouseLeave

        UI_Main_PrimType.ForeColor = ML_Color

    End Sub

    Private Sub UI_Main_PrimPosition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Main_PrimPosition.Click

        UI_InitPanels()
        UserMode = User_MovePrimitive

    End Sub

    Private Sub UI_Main_PrimPosition_MouseEnter(sender As Object, e As EventArgs) Handles UI_Main_PrimPosition.MouseEnter

        ML_Color = UI_Main_PrimPosition.ForeColor
        UI_Main_PrimPosition.ForeColor = MO_Color

    End Sub

    Private Sub UI_Main_PrimPosition_MouseLeave(sender As Object, e As EventArgs) Handles UI_Main_PrimPosition.MouseLeave

        UI_Main_PrimPosition.ForeColor = ML_Color

    End Sub

    Private Sub UI_Main_PrimRotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Main_PrimRotation.Click

        UI_InitPanels()
        UserMode = User_RotatePrimitive

    End Sub

    Private Sub UI_Main_PrimRotation_MouseEnter(sender As Object, e As EventArgs) Handles UI_Main_PrimRotation.MouseEnter

        ML_Color = UI_Main_PrimRotation.ForeColor
        UI_Main_PrimRotation.ForeColor = MO_Color

    End Sub

    Private Sub UI_Main_PrimRotation_MouseLeave(sender As Object, e As EventArgs) Handles UI_Main_PrimRotation.MouseLeave

        UI_Main_PrimRotation.ForeColor = ML_Color

    End Sub

    Private Sub UI_Main_Perspective_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Main_Perspective.Click

        UI_InitPanels()
        UserMode = User_Perspective

    End Sub

    Private Sub UI_Main_Perspective_MouseEnter(sender As Object, e As EventArgs) Handles UI_Main_Perspective.MouseEnter

        ML_Color = UI_Main_Perspective.ForeColor
        UI_Main_Perspective.ForeColor = MO_Color

    End Sub

    Private Sub UI_Main_Perspective_MouseLeave(sender As Object, e As EventArgs) Handles UI_Main_Perspective.MouseLeave

        UI_Main_Perspective.ForeColor = ML_Color

    End Sub

    Private Sub UI_Main_Zoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Main_Zoom.Click

        UI_InitPanels()
        UserMode = User_Zoom

    End Sub

    Private Sub UI_Main_Zoom_MouseEnter(sender As Object, e As EventArgs) Handles UI_Main_Zoom.MouseEnter

        ML_Color = UI_Main_Zoom.ForeColor
        UI_Main_Zoom.ForeColor = MO_Color

    End Sub

    Private Sub UI_Main_Zoom_MouseLeave(sender As Object, e As EventArgs) Handles UI_Main_Zoom.MouseLeave

        UI_Main_Zoom.ForeColor = ML_Color

    End Sub

    Private Sub UI_Main_Light_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Main_Light.Click

        UI_InitPanels()
        UI_ShowLightPanel()

    End Sub

    Private Sub UI_Main_Light_MouseEnter(sender As Object, e As EventArgs) Handles UI_Main_Light.MouseEnter

        ML_Color = UI_Main_Light.ForeColor
        UI_Main_Light.ForeColor = MO_Color

    End Sub

    Private Sub UI_Main_Light_MouseLeave(sender As Object, e As EventArgs) Handles UI_Main_Light.MouseLeave

        UI_Main_Light.ForeColor = ML_Color

    End Sub

    Private Sub UI_Main_Render_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Main_Render.Click

        UI_InitPanels()
        UI_ShowRenderPanel()

    End Sub

    Private Sub UI_Main_Render_MouseEnter(sender As Object, e As EventArgs) Handles UI_Main_Render.MouseEnter

        ML_Color = UI_Main_Render.ForeColor
        UI_Main_Render.ForeColor = MO_Color

    End Sub

    Private Sub UI_Main_Render_MouseLeave(sender As Object, e As EventArgs) Handles UI_Main_Render.MouseLeave

        UI_Main_Render.ForeColor = ML_Color

    End Sub

    Private Sub UI_Main_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Main_About.Click

        UI_InitPanels()
        UI_ShowAboutPanel()

    End Sub

    Private Sub UI_Main_About_MouseEnter(sender As Object, e As EventArgs) Handles UI_Main_About.MouseEnter

        ML_Color = UI_Main_About.ForeColor
        UI_Main_About.ForeColor = MO_Color

    End Sub

    Private Sub UI_Main_About_MouseLeave(sender As Object, e As EventArgs) Handles UI_Main_About.MouseLeave

        UI_Main_About.ForeColor = ML_Color

    End Sub

    Private Sub Panel_About_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel_About.Click

        UI_InitPanels()

    End Sub

    Private Sub UI_Lightsource_LightX_TextChanged(sender As Object, e As EventArgs) Handles UI_Lightsource_LightX.Validated

        Dim InitVal As Single
        InitVal = Light_NormalX

        Light_NormalX = Val(Me.UI_Lightsource_LightX.Text)

        If Light_NormalX < -1 Then

            MsgBox("This value must be betwen -1 and 1")
            Light_NormalX = InitVal

        End If

        If Light_NormalX > 1 Then

            MsgBox("This value must be betwen -1 and 1")
            Light_NormalX = InitVal

        End If

        Me.UI_Lightsource_LightX.Text = Str(Light_NormalX)

        Update_Light()

    End Sub

    Private Sub UI_Lightsource_LightY_TextChanged(sender As Object, e As EventArgs) Handles UI_Lightsource_LightY.Validated

        Dim InitVal As Single
        InitVal = Light_NormalY

        Light_NormalY = Val(Me.UI_Lightsource_LightY.Text)

        If Light_NormalY < -1 Then

            MsgBox("This value must be betwen -1 and 1")
            Light_NormalY = InitVal

        End If

        If Light_NormalY > 1 Then

            MsgBox("This value must be betwen -1 and 1")
            Light_NormalY = InitVal

        End If

        Me.UI_Lightsource_LightY.Text = Str(Light_NormalY)

        Update_Light()

    End Sub

    Private Sub UI_Lightsource_LightZ_TextChanged(sender As Object, e As EventArgs) Handles UI_Lightsource_LightZ.Validated

        Dim InitVal As Single
        InitVal = Light_NormalZ

        Light_NormalZ = Val(Me.UI_Lightsource_LightZ.Text)

        If Light_NormalZ < -1 Then

            MsgBox("This value must be betwen -1 and 1")
            Light_NormalZ = InitVal

        End If

        If Light_NormalZ > 1 Then

            MsgBox("This value must be betwen -1 and 1")
            Light_NormalZ = InitVal

        End If

        Me.UI_Lightsource_LightZ.Text = Str(Light_NormalZ)

        Update_Light()

    End Sub

    Private Sub UI_Lightsource_LightIntensity_TextChanged(sender As Object, e As EventArgs) Handles UI_Lightsource_LightIntensity.Validated

        Dim InitVal As Single
        InitVal = Light_Int_Value

        Light_Int_Value = Val(Me.UI_Lightsource_LightIntensity.Text)

        If Light_Int_Value < 0 Then

            MsgBox("This value must be betwee 0 and 100")
            Light_Int_Value = InitVal

        End If

        If Light_Int_Value > 100 Then

            MsgBox("This value must be betwen 0 and 100")
            Light_Int_Value = InitVal

        End If

        Me.UI_Lightsource_LightIntensity.Text = Str(Light_Int_Value)

        Update_Light()

    End Sub

    Private Sub UI_Primitives_Cube_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Primitives_Cube.Click

        UI_InitPanels()
        ShowHidenFace = False
        Primitive_Type = Cube
        Main3d()

    End Sub

    Private Sub UI_Primitives_Cube_MouseEnter(sender As Object, e As EventArgs) Handles UI_Primitives_Cube.MouseEnter

        ML_Color = UI_Primitives_Cube.ForeColor
        UI_Primitives_Cube.ForeColor = MO_Color

    End Sub

    Private Sub UI_Primitives_Cube_MouseLeave(sender As Object, e As EventArgs) Handles UI_Primitives_Cube.MouseLeave

        UI_Primitives_Cube.ForeColor = ML_Color

    End Sub

    Private Sub UI_Primitives_Cylinder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Primitives_Cylinder.Click

        UI_InitPanels()
        ShowHidenFace = False
        Primitive_Type = Cylinder
        Main3d()

    End Sub

    Private Sub UI_Primitives_Cylinder_MouseEnter(sender As Object, e As EventArgs) Handles UI_Primitives_Cylinder.MouseEnter

        ML_Color = UI_Primitives_Cylinder.ForeColor
        UI_Primitives_Cylinder.ForeColor = MO_Color

    End Sub

    Private Sub UI_Primitives_Cylinder_MouseLeave(sender As Object, e As EventArgs) Handles UI_Primitives_Cylinder.MouseLeave

        UI_Primitives_Cylinder.ForeColor = ML_Color

    End Sub

    Private Sub UI_Primitives_Sphere_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Primitives_Sphere.Click

        UI_InitPanels()
        ShowHidenFace = False
        Primitive_Type = Sphere
        Main3d()

    End Sub

    Private Sub UI_Primitives_Sphere_MouseEnter(sender As Object, e As EventArgs) Handles UI_Primitives_Sphere.MouseEnter

        ML_Color = UI_Primitives_Sphere.ForeColor
        UI_Primitives_Sphere.ForeColor = MO_Color

    End Sub

    Private Sub UI_Primitives_Sphere_MouseLeave(sender As Object, e As EventArgs) Handles UI_Primitives_Sphere.MouseLeave

        UI_Primitives_Sphere.ForeColor = ML_Color

    End Sub

    Private Sub UI_Primitives_Torus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Primitives_Torus.Click

        UI_InitPanels()
        ShowHidenFace = False
        Primitive_Type = Torus
        Main3d()

    End Sub

    Private Sub UI_Primitives_Torus_MouseEnter(sender As Object, e As EventArgs) Handles UI_Primitives_Torus.MouseEnter

        ML_Color = UI_Primitives_Torus.ForeColor
        UI_Primitives_Torus.ForeColor = MO_Color

    End Sub

    Private Sub UI_Primitives_Torus_MouseLeave(sender As Object, e As EventArgs) Handles UI_Primitives_Torus.MouseLeave

        UI_Primitives_Torus.ForeColor = ML_Color

    End Sub

    Private Sub UI_Primitives_Glenz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Primitives_Glenz.Click

        UI_InitPanels()
        ShowHidenFace = True
        Primitive_Type = Glenz
        Main3d()

    End Sub

    Private Sub UI_Primitives_Glenz_MouseEnter(sender As Object, e As EventArgs) Handles UI_Primitives_Glenz.MouseEnter

        ML_Color = UI_Primitives_Glenz.ForeColor
        UI_Primitives_Glenz.ForeColor = MO_Color

    End Sub

    Private Sub UI_Primitives_Glenz_MouseLeave(sender As Object, e As EventArgs) Handles UI_Primitives_Glenz.MouseLeave

        UI_Primitives_Glenz.ForeColor = ML_Color

    End Sub

    Private Sub UI_Primitives_Spiral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Primitives_Spiral.Click

        UI_InitPanels()
        ShowHidenFace = False
        Primitive_Type = Spiral
        Main3d()

    End Sub

    Private Sub UI_Primitives_Spiral_MouseEnter(sender As Object, e As EventArgs) Handles UI_Primitives_Spiral.MouseEnter

        ML_Color = UI_Primitives_Spiral.ForeColor
        UI_Primitives_Spiral.ForeColor = MO_Color

    End Sub

    Private Sub UI_Primitives_Spiral_MouseLeave(sender As Object, e As EventArgs) Handles UI_Primitives_Spiral.MouseLeave

        UI_Primitives_Spiral.ForeColor = ML_Color

    End Sub

    Private Sub UI_Render_Wireframe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Render_Wireframe.Click

        Primitive_RenderMode = Wireframe
        ShowHidenFace = False
        Me.Canvas.BackColor = WfBackColor
        UI_InitPanels()

    End Sub

    Private Sub UI_Render_Wireframe_MouseEnter(sender As Object, e As EventArgs) Handles UI_Render_Wireframe.MouseEnter

        ML_Color = UI_Render_Wireframe.ForeColor
        UI_Render_Wireframe.ForeColor = MO_Color

    End Sub

    Private Sub UI_Render_Wireframe_MouseLeave(sender As Object, e As EventArgs) Handles UI_Render_Wireframe.MouseLeave

        UI_Render_Wireframe.ForeColor = ML_Color

    End Sub

    Private Sub UI_Render_WireframeHidenFace_Click(sender As Object, e As EventArgs) Handles UI_Render_WireframeHidenFace.Click

        Primitive_RenderMode = WireframeShowHFace
        Me.Canvas.BackColor = WfBackColor
        UI_InitPanels()

    End Sub

    Private Sub UI_Render_WireframeHidenFace_MouseEnter(sender As Object, e As EventArgs) Handles UI_Render_WireframeHidenFace.MouseEnter

        ML_Color = UI_Render_WireframeHidenFace.ForeColor
        UI_Render_WireframeHidenFace.ForeColor = MO_Color

    End Sub

    Private Sub UI_Render_WireframeHidenFace_MouseLeave(sender As Object, e As EventArgs) Handles UI_Render_WireframeHidenFace.MouseLeave

        UI_Render_WireframeHidenFace.ForeColor = ML_Color

    End Sub

    Private Sub UI_Render_Solid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Render_Solid.Click

        Primitive_RenderMode = Solid
        ShowHidenFace = False
        Me.Canvas.BackColor = InitBackColor
        UI_InitPanels()

    End Sub

    Private Sub UI_Render_Solid_MouseEnter(sender As Object, e As EventArgs) Handles UI_Render_Solid.MouseEnter

        ML_Color = UI_Render_Solid.ForeColor
        UI_Render_Solid.ForeColor = MO_Color

    End Sub

    Private Sub UI_Render_Solid_MouseLeave(sender As Object, e As EventArgs) Handles UI_Render_Solid.MouseLeave

        UI_Render_Solid.ForeColor = ML_Color

    End Sub

    Private Sub UI_Render_SolidHQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Render_SolidHQ.Click

        Primitive_RenderMode = SolidHQ
        ShowHidenFace = False
        Me.Canvas.BackColor = InitBackColor
        UI_InitPanels()

    End Sub

    Private Sub UI_Render_SolidHQ_MouseEnter(sender As Object, e As EventArgs) Handles UI_Render_SolidHQ.MouseEnter

        ML_Color = UI_Render_SolidHQ.ForeColor
        UI_Render_SolidHQ.ForeColor = MO_Color

    End Sub

    Private Sub UI_Render_SolidHQ_MouseLeave(sender As Object, e As EventArgs) Handles UI_Render_SolidHQ.MouseLeave

        UI_Render_SolidHQ.ForeColor = ML_Color

    End Sub

    Private Sub UI_Render_SolidPlusWireframe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Render_SolidPlusWireframe.Click

        Primitive_RenderMode = SolidPlusWireframe
        ShowHidenFace = False
        Me.Canvas.BackColor = InitBackColor
        UI_InitPanels()

    End Sub

    Private Sub UI_Render_SolidPlusWireframe_MouseEnter(sender As Object, e As EventArgs) Handles UI_Render_SolidPlusWireframe.MouseEnter

        ML_Color = UI_Render_SolidPlusWireframe.ForeColor
        UI_Render_SolidPlusWireframe.ForeColor = MO_Color

    End Sub

    Private Sub UI_Render_SolidPlusWireframe_MouseLeave(sender As Object, e As EventArgs) Handles UI_Render_SolidPlusWireframe.MouseLeave

        UI_Render_SolidPlusWireframe.ForeColor = ML_Color

    End Sub

    Private Sub UI_Render_NoShading_Click(sender As Object, e As EventArgs) Handles UI_Render_NoShading.Click

        Primitive_RenderMode = NoShading
        ShowHidenFace = False
        Me.Canvas.BackColor = InitBackColor
        UI_InitPanels()

    End Sub

    Private Sub UI_Render_NoShading_MouseEnter(sender As Object, e As EventArgs) Handles UI_Render_NoShading.MouseEnter

        ML_Color = UI_Render_NoShading.ForeColor
        UI_Render_NoShading.ForeColor = MO_Color

    End Sub

    Private Sub UI_Render_NoShading_MouseLeave(sender As Object, e As EventArgs) Handles UI_Render_NoShading.MouseLeave

        UI_Render_NoShading.ForeColor = ML_Color

    End Sub

    Private Sub UI_Main_DemoMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UI_Main_DemoMode.Click

        Start_DemoMode()

    End Sub

    Private Sub UI_Main_DemoMode_MouseEnter(sender As Object, e As EventArgs) Handles UI_Main_DemoMode.MouseEnter

        ML_Color = UI_Main_DemoMode.ForeColor
        UI_Main_DemoMode.ForeColor = MO_Color

    End Sub

    Private Sub UI_Main_DemoMode_MouseLeave(sender As Object, e As EventArgs) Handles UI_Main_DemoMode.MouseLeave

        UI_Main_DemoMode.ForeColor = ML_Color

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If UserMode = DemoMode Then

            ' Demo mode

            If DemoP = 1 Then Primitive_Type = Cube : Zoom = 1.5 : Perspective = 0.002 : ShowHidenFace = False
            If DemoP = 2 Then Primitive_Type = Cylinder : Zoom = 1.75 : Perspective = 0.004 : ShowHidenFace = False
            If DemoP = 3 Then Primitive_Type = Sphere : Zoom = 2 : Perspective = 0.006 : ShowHidenFace = False
            If DemoP = 4 Then Primitive_Type = Glenz : Zoom = 1.8 : Perspective = 0.005 : ShowHidenFace = True
            If DemoP = 5 Then Primitive_Type = Torus : Zoom = 3 : Perspective = 0.004 : ShowHidenFace = False
            If DemoP = 6 Then Primitive_Type = Spiral : Zoom = 3 : Perspective = 0.006 : ShowHidenFace = False

            DemoR = (Me.Canvas.Width) * 1.1
            Primitive_XPos = DemoR + DemoR * Math.Cos(DemoA * CDeg)

            If DemoD > 0 Then

                DemoA = DemoA + DemoD
                If DemoA > 180 Then DemoA = 180

            End If

            If DemoD < 0 Then

                DemoA = DemoA + DemoD

                If DemoA < 90 Then

                    DemoA = 90
                    DemoD = DemoD * -1
                    DemoTime = 0
                    DemoP = DemoP + 1

                    If DemoP > 6 Then

                        DemoP = 1

                    End If

                End If

            End If

            If DemoTime = 600 Then

                DemoD = DemoD * -1

            End If

            ' Continuous rotating

            Primitive_XAngle = Primitive_XAngle + 0.25
            Primitive_YAngle = Primitive_YAngle + 0.75
            Primitive_ZAngle = Primitive_ZAngle - 0.15

            TestAngle()

            DemoTime = DemoTime + 1

        Else

            Me.Timer1.Enabled = False

        End If

        Main3d()

    End Sub

    Private Sub UI_Main_UserMode_MouseEnter(sender As Object, e As EventArgs) Handles UI_Main_UserMode.MouseEnter

        ML_Color = UI_Main_UserMode.ForeColor
        UI_Main_UserMode.ForeColor = MO_Color
        UI_Main_PrimType.ForeColor = MO_Color
        UI_Main_PrimPosition.ForeColor = MO_Color
        UI_Main_PrimRotation.ForeColor = MO_Color
        UI_Main_Perspective.ForeColor = MO_Color
        UI_Main_Zoom.ForeColor = MO_Color

    End Sub

    Private Sub UI_Main_UserMode_MouseLeave(sender As Object, e As EventArgs) Handles UI_Main_UserMode.MouseLeave

        UI_Main_UserMode.ForeColor = ML_Color
        UI_Main_PrimType.ForeColor = ML_Color
        UI_Main_PrimPosition.ForeColor = ML_Color
        UI_Main_PrimRotation.ForeColor = ML_Color
        UI_Main_Perspective.ForeColor = ML_Color
        UI_Main_Zoom.ForeColor = ML_Color

    End Sub

    Private Sub Sylfx3dPureVb_SideImage_Click(sender As Object, e As EventArgs) Handles Sylfx3dPureVb_SideImage.Click
        UI_ShowMainPanel()
    End Sub

    Public Sub Start_DemoMode()

        UI_InitPanels()

        ' Updating

        Init_Primitive_Type = Primitive_Type
        Init_Primitive_RenderMode = Primitive_RenderMode
        Init_Primitive_XPos = Primitive_XPos
        Init_Primitive_YPos = Primitive_YPos
        Init_Primitive_ZPos = Primitive_ZPos
        Init_Primitive_XAngle = Primitive_XAngle
        Init_Primitive_YAngle = Primitive_YAngle
        Init_Primitive_ZAngle = Primitive_ZAngle
        Init_Zoom = Zoom
        Init_Perspective = Perspective
        Init_Backcolor = Me.Canvas.BackColor

        ' Initialize - Demo mode

        Init3d()

        UserMode = DemoMode
        DemoTime = 0
        DemoA = 90
        DemoD = 1.5
        DemoP = 1
        Me.Timer1.Interval = 1
        Me.Timer1.Enabled = True

    End Sub

    Public Sub End_DemoMode()

        Primitive_Type = Init_Primitive_Type
        Primitive_RenderMode = Init_Primitive_RenderMode
        Primitive_XPos = Init_Primitive_XPos
        Primitive_YPos = Init_Primitive_YPos
        Primitive_ZPos = Init_Primitive_ZPos
        Primitive_XAngle = Init_Primitive_XAngle
        Primitive_YAngle = Init_Primitive_YAngle
        Primitive_ZAngle = Init_Primitive_ZAngle
        Zoom = Init_Zoom
        Perspective = Init_Perspective
        Me.Timer1.Enabled = False

    End Sub

    Private Sub Canvas_MouseEnter(sender As Object, e As EventArgs) Handles Canvas.MouseEnter
        UI_InitPanels()
    End Sub

End Class
