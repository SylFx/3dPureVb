<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Canvas = New System.Windows.Forms.PictureBox()
        Me.Panel_MainMenu = New System.Windows.Forms.Panel()
        Me.UI_Main_DemoMode = New System.Windows.Forms.Label()
        Me.UI_Main_About = New System.Windows.Forms.Label()
        Me.UI_Main_Quit = New System.Windows.Forms.Label()
        Me.UI_Main_Hide = New System.Windows.Forms.Label()
        Me.UI_Main_Render = New System.Windows.Forms.Label()
        Me.UI_Main_Light = New System.Windows.Forms.Label()
        Me.UI_Main_Zoom = New System.Windows.Forms.Label()
        Me.UI_Main_Perspective = New System.Windows.Forms.Label()
        Me.UI_Main_PrimRotation = New System.Windows.Forms.Label()
        Me.UI_Main_PrimPosition = New System.Windows.Forms.Label()
        Me.UI_Main_PrimType = New System.Windows.Forms.Label()
        Me.UI_Main_UserMode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Primitive = New System.Windows.Forms.Panel()
        Me.UI_Primitives_Spiral = New System.Windows.Forms.Label()
        Me.UI_Primitives_Glenz = New System.Windows.Forms.Label()
        Me.UI_Primitives_Torus = New System.Windows.Forms.Label()
        Me.UI_Primitives_Sphere = New System.Windows.Forms.Label()
        Me.UI_Primitives_Cylinder = New System.Windows.Forms.Label()
        Me.UI_Primitives_Cube = New System.Windows.Forms.Label()
        Me.UI_Primitives = New System.Windows.Forms.Label()
        Me.Panel_About = New System.Windows.Forms.Panel()
        Me.UI_About_WwwSylfxNet = New System.Windows.Forms.Label()
        Me.UI_About_Copyright2013SylvainSIMON = New System.Windows.Forms.Label()
        Me.UI_About_Sylfx3dPureVb = New System.Windows.Forms.Label()
        Me.Panel_Light = New System.Windows.Forms.Panel()
        Me.UI_Lightsource_Light = New System.Windows.Forms.Label()
        Me.UI_Lightsource_LightIntensity = New System.Windows.Forms.TextBox()
        Me.UI_Lightsource_LightZ = New System.Windows.Forms.TextBox()
        Me.UI_Lightsource_LightY = New System.Windows.Forms.TextBox()
        Me.UI_Lightsource_LightX = New System.Windows.Forms.TextBox()
        Me.UI_Lightsource_Intensity = New System.Windows.Forms.Label()
        Me.UI_Lightsource_Z = New System.Windows.Forms.Label()
        Me.UI_Lightsource_Y = New System.Windows.Forms.Label()
        Me.UI_Lightsource_X = New System.Windows.Forms.Label()
        Me.UI_Lightsource_Vector = New System.Windows.Forms.Label()
        Me.Panel_Render = New System.Windows.Forms.Panel()
        Me.UI_Render_NoShading = New System.Windows.Forms.Label()
        Me.UI_Render_WireframeHidenFace = New System.Windows.Forms.Label()
        Me.UI_Render_SolidHQ = New System.Windows.Forms.Label()
        Me.UI_Render_SolidPlusWireframe = New System.Windows.Forms.Label()
        Me.UI_Render_Solid = New System.Windows.Forms.Label()
        Me.UI_Render_Wireframe = New System.Windows.Forms.Label()
        Me.UI_Render_Rendermode = New System.Windows.Forms.Label()
        Me.Sylfx3dPureVb_SideImage = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Canvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_MainMenu.SuspendLayout()
        Me.Panel_Primitive.SuspendLayout()
        Me.Panel_About.SuspendLayout()
        Me.Panel_Light.SuspendLayout()
        Me.Panel_Render.SuspendLayout()
        CType(Me.Sylfx3dPureVb_SideImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Canvas
        '
        Me.Canvas.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Canvas.ErrorImage = CType(resources.GetObject("Canvas.ErrorImage"), System.Drawing.Image)
        Me.Canvas.Location = New System.Drawing.Point(7, 1)
        Me.Canvas.Name = "Canvas"
        Me.Canvas.Size = New System.Drawing.Size(1024, 520)
        Me.Canvas.TabIndex = 0
        Me.Canvas.TabStop = False
        '
        'Panel_MainMenu
        '
        Me.Panel_MainMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Panel_MainMenu.Controls.Add(Me.UI_Main_DemoMode)
        Me.Panel_MainMenu.Controls.Add(Me.UI_Main_About)
        Me.Panel_MainMenu.Controls.Add(Me.UI_Main_Quit)
        Me.Panel_MainMenu.Controls.Add(Me.UI_Main_Hide)
        Me.Panel_MainMenu.Controls.Add(Me.UI_Main_Render)
        Me.Panel_MainMenu.Controls.Add(Me.UI_Main_Light)
        Me.Panel_MainMenu.Controls.Add(Me.UI_Main_Zoom)
        Me.Panel_MainMenu.Controls.Add(Me.UI_Main_Perspective)
        Me.Panel_MainMenu.Controls.Add(Me.UI_Main_PrimRotation)
        Me.Panel_MainMenu.Controls.Add(Me.UI_Main_PrimPosition)
        Me.Panel_MainMenu.Controls.Add(Me.UI_Main_PrimType)
        Me.Panel_MainMenu.Controls.Add(Me.UI_Main_UserMode)
        Me.Panel_MainMenu.Controls.Add(Me.Label1)
        Me.Panel_MainMenu.Enabled = False
        Me.Panel_MainMenu.Location = New System.Drawing.Point(97, 0)
        Me.Panel_MainMenu.Name = "Panel_MainMenu"
        Me.Panel_MainMenu.Size = New System.Drawing.Size(309, 552)
        Me.Panel_MainMenu.TabIndex = 2
        Me.Panel_MainMenu.Visible = False
        '
        'UI_Main_DemoMode
        '
        Me.UI_Main_DemoMode.AutoSize = True
        Me.UI_Main_DemoMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Main_DemoMode.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_Main_DemoMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Main_DemoMode.Location = New System.Drawing.Point(0, 312)
        Me.UI_Main_DemoMode.Name = "UI_Main_DemoMode"
        Me.UI_Main_DemoMode.Size = New System.Drawing.Size(174, 40)
        Me.UI_Main_DemoMode.TabIndex = 18
        Me.UI_Main_DemoMode.Text = "Demo mode"
        '
        'UI_Main_About
        '
        Me.UI_Main_About.AutoSize = True
        Me.UI_Main_About.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.UI_Main_About.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UI_Main_About.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Main_About.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_Main_About.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Main_About.Location = New System.Drawing.Point(270, 470)
        Me.UI_Main_About.Name = "UI_Main_About"
        Me.UI_Main_About.Size = New System.Drawing.Size(32, 42)
        Me.UI_Main_About.TabIndex = 17
        Me.UI_Main_About.Text = "?"
        '
        'UI_Main_Quit
        '
        Me.UI_Main_Quit.AutoSize = True
        Me.UI_Main_Quit.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.UI_Main_Quit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UI_Main_Quit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Main_Quit.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_Main_Quit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Main_Quit.Location = New System.Drawing.Point(100, 470)
        Me.UI_Main_Quit.Name = "UI_Main_Quit"
        Me.UI_Main_Quit.Size = New System.Drawing.Size(94, 42)
        Me.UI_Main_Quit.TabIndex = 16
        Me.UI_Main_Quit.Text = "  Exit  "
        '
        'UI_Main_Hide
        '
        Me.UI_Main_Hide.AutoSize = True
        Me.UI_Main_Hide.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.UI_Main_Hide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UI_Main_Hide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Main_Hide.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_Main_Hide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Main_Hide.Location = New System.Drawing.Point(7, 470)
        Me.UI_Main_Hide.Name = "UI_Main_Hide"
        Me.UI_Main_Hide.Size = New System.Drawing.Size(87, 42)
        Me.UI_Main_Hide.TabIndex = 15
        Me.UI_Main_Hide.Text = "Close"
        '
        'UI_Main_Render
        '
        Me.UI_Main_Render.AutoSize = True
        Me.UI_Main_Render.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Main_Render.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_Main_Render.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Main_Render.Location = New System.Drawing.Point(0, 392)
        Me.UI_Main_Render.Name = "UI_Main_Render"
        Me.UI_Main_Render.Size = New System.Drawing.Size(187, 40)
        Me.UI_Main_Render.TabIndex = 13
        Me.UI_Main_Render.Text = "Render mode"
        '
        'UI_Main_Light
        '
        Me.UI_Main_Light.AutoSize = True
        Me.UI_Main_Light.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Main_Light.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_Main_Light.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Main_Light.Location = New System.Drawing.Point(0, 352)
        Me.UI_Main_Light.Name = "UI_Main_Light"
        Me.UI_Main_Light.Size = New System.Drawing.Size(117, 40)
        Me.UI_Main_Light.TabIndex = 11
        Me.UI_Main_Light.Text = "Lighting"
        '
        'UI_Main_Zoom
        '
        Me.UI_Main_Zoom.AutoSize = True
        Me.UI_Main_Zoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Main_Zoom.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_Main_Zoom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Main_Zoom.Location = New System.Drawing.Point(20, 272)
        Me.UI_Main_Zoom.Name = "UI_Main_Zoom"
        Me.UI_Main_Zoom.Size = New System.Drawing.Size(92, 40)
        Me.UI_Main_Zoom.TabIndex = 6
        Me.UI_Main_Zoom.Text = "Zoom"
        '
        'UI_Main_Perspective
        '
        Me.UI_Main_Perspective.AutoSize = True
        Me.UI_Main_Perspective.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Main_Perspective.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_Main_Perspective.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Main_Perspective.Location = New System.Drawing.Point(20, 232)
        Me.UI_Main_Perspective.Name = "UI_Main_Perspective"
        Me.UI_Main_Perspective.Size = New System.Drawing.Size(158, 40)
        Me.UI_Main_Perspective.TabIndex = 5
        Me.UI_Main_Perspective.Text = "Perspective"
        '
        'UI_Main_PrimRotation
        '
        Me.UI_Main_PrimRotation.AutoSize = True
        Me.UI_Main_PrimRotation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Main_PrimRotation.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_Main_PrimRotation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Main_PrimRotation.Location = New System.Drawing.Point(20, 192)
        Me.UI_Main_PrimRotation.Name = "UI_Main_PrimRotation"
        Me.UI_Main_PrimRotation.Size = New System.Drawing.Size(122, 40)
        Me.UI_Main_PrimRotation.TabIndex = 4
        Me.UI_Main_PrimRotation.Text = "Rotation"
        '
        'UI_Main_PrimPosition
        '
        Me.UI_Main_PrimPosition.AutoSize = True
        Me.UI_Main_PrimPosition.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Main_PrimPosition.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_Main_PrimPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Main_PrimPosition.Location = New System.Drawing.Point(20, 152)
        Me.UI_Main_PrimPosition.Name = "UI_Main_PrimPosition"
        Me.UI_Main_PrimPosition.Size = New System.Drawing.Size(115, 40)
        Me.UI_Main_PrimPosition.TabIndex = 3
        Me.UI_Main_PrimPosition.Text = "Position"
        '
        'UI_Main_PrimType
        '
        Me.UI_Main_PrimType.AutoSize = True
        Me.UI_Main_PrimType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Main_PrimType.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_Main_PrimType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Main_PrimType.Location = New System.Drawing.Point(20, 112)
        Me.UI_Main_PrimType.Name = "UI_Main_PrimType"
        Me.UI_Main_PrimType.Size = New System.Drawing.Size(186, 40)
        Me.UI_Main_PrimType.TabIndex = 2
        Me.UI_Main_PrimType.Text = "Primitive type"
        '
        'UI_Main_UserMode
        '
        Me.UI_Main_UserMode.AutoSize = True
        Me.UI_Main_UserMode.Cursor = System.Windows.Forms.Cursors.Default
        Me.UI_Main_UserMode.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_Main_UserMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Main_UserMode.Location = New System.Drawing.Point(0, 72)
        Me.UI_Main_UserMode.Name = "UI_Main_UserMode"
        Me.UI_Main_UserMode.Size = New System.Drawing.Size(154, 40)
        Me.UI_Main_UserMode.TabIndex = 1
        Me.UI_Main_UserMode.Text = "User mode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "3 d P u r e V b "
        '
        'Panel_Primitive
        '
        Me.Panel_Primitive.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Panel_Primitive.Controls.Add(Me.UI_Primitives_Spiral)
        Me.Panel_Primitive.Controls.Add(Me.UI_Primitives_Glenz)
        Me.Panel_Primitive.Controls.Add(Me.UI_Primitives_Torus)
        Me.Panel_Primitive.Controls.Add(Me.UI_Primitives_Sphere)
        Me.Panel_Primitive.Controls.Add(Me.UI_Primitives_Cylinder)
        Me.Panel_Primitive.Controls.Add(Me.UI_Primitives_Cube)
        Me.Panel_Primitive.Controls.Add(Me.UI_Primitives)
        Me.Panel_Primitive.Location = New System.Drawing.Point(708, 1)
        Me.Panel_Primitive.Name = "Panel_Primitive"
        Me.Panel_Primitive.Size = New System.Drawing.Size(309, 560)
        Me.Panel_Primitive.TabIndex = 3
        Me.Panel_Primitive.Visible = False
        '
        'UI_Primitives_Spiral
        '
        Me.UI_Primitives_Spiral.AutoSize = True
        Me.UI_Primitives_Spiral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Primitives_Spiral.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Primitives_Spiral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Primitives_Spiral.Location = New System.Drawing.Point(0, 311)
        Me.UI_Primitives_Spiral.Name = "UI_Primitives_Spiral"
        Me.UI_Primitives_Spiral.Size = New System.Drawing.Size(86, 40)
        Me.UI_Primitives_Spiral.TabIndex = 15
        Me.UI_Primitives_Spiral.Text = "Spiral"
        '
        'UI_Primitives_Glenz
        '
        Me.UI_Primitives_Glenz.AutoSize = True
        Me.UI_Primitives_Glenz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Primitives_Glenz.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Primitives_Glenz.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Primitives_Glenz.Location = New System.Drawing.Point(0, 231)
        Me.UI_Primitives_Glenz.Name = "UI_Primitives_Glenz"
        Me.UI_Primitives_Glenz.Size = New System.Drawing.Size(87, 40)
        Me.UI_Primitives_Glenz.TabIndex = 14
        Me.UI_Primitives_Glenz.Text = "Glenz"
        '
        'UI_Primitives_Torus
        '
        Me.UI_Primitives_Torus.AutoSize = True
        Me.UI_Primitives_Torus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Primitives_Torus.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Primitives_Torus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Primitives_Torus.Location = New System.Drawing.Point(0, 271)
        Me.UI_Primitives_Torus.Name = "UI_Primitives_Torus"
        Me.UI_Primitives_Torus.Size = New System.Drawing.Size(84, 40)
        Me.UI_Primitives_Torus.TabIndex = 12
        Me.UI_Primitives_Torus.Text = "Torus"
        '
        'UI_Primitives_Sphere
        '
        Me.UI_Primitives_Sphere.AutoSize = True
        Me.UI_Primitives_Sphere.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Primitives_Sphere.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Primitives_Sphere.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Primitives_Sphere.Location = New System.Drawing.Point(0, 191)
        Me.UI_Primitives_Sphere.Name = "UI_Primitives_Sphere"
        Me.UI_Primitives_Sphere.Size = New System.Drawing.Size(105, 40)
        Me.UI_Primitives_Sphere.TabIndex = 11
        Me.UI_Primitives_Sphere.Text = "Sphere"
        '
        'UI_Primitives_Cylinder
        '
        Me.UI_Primitives_Cylinder.AutoSize = True
        Me.UI_Primitives_Cylinder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Primitives_Cylinder.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Primitives_Cylinder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Primitives_Cylinder.Location = New System.Drawing.Point(0, 151)
        Me.UI_Primitives_Cylinder.Name = "UI_Primitives_Cylinder"
        Me.UI_Primitives_Cylinder.Size = New System.Drawing.Size(119, 40)
        Me.UI_Primitives_Cylinder.TabIndex = 10
        Me.UI_Primitives_Cylinder.Text = "Cylinder"
        '
        'UI_Primitives_Cube
        '
        Me.UI_Primitives_Cube.AutoSize = True
        Me.UI_Primitives_Cube.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Primitives_Cube.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Primitives_Cube.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Primitives_Cube.Location = New System.Drawing.Point(0, 111)
        Me.UI_Primitives_Cube.Name = "UI_Primitives_Cube"
        Me.UI_Primitives_Cube.Size = New System.Drawing.Size(83, 40)
        Me.UI_Primitives_Cube.TabIndex = 9
        Me.UI_Primitives_Cube.Text = "Cube"
        '
        'UI_Primitives
        '
        Me.UI_Primitives.AutoSize = True
        Me.UI_Primitives.Cursor = System.Windows.Forms.Cursors.Default
        Me.UI_Primitives.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Primitives.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Primitives.Location = New System.Drawing.Point(0, 7)
        Me.UI_Primitives.Name = "UI_Primitives"
        Me.UI_Primitives.Size = New System.Drawing.Size(186, 40)
        Me.UI_Primitives.TabIndex = 8
        Me.UI_Primitives.Text = "Primitive type"
        '
        'Panel_About
        '
        Me.Panel_About.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Panel_About.Controls.Add(Me.UI_About_WwwSylfxNet)
        Me.Panel_About.Controls.Add(Me.UI_About_Copyright2013SylvainSIMON)
        Me.Panel_About.Controls.Add(Me.UI_About_Sylfx3dPureVb)
        Me.Panel_About.Location = New System.Drawing.Point(1075, 1)
        Me.Panel_About.Name = "Panel_About"
        Me.Panel_About.Size = New System.Drawing.Size(359, 552)
        Me.Panel_About.TabIndex = 18
        Me.Panel_About.Visible = False
        '
        'UI_About_WwwSylfxNet
        '
        Me.UI_About_WwwSylfxNet.AutoSize = True
        Me.UI_About_WwwSylfxNet.Cursor = System.Windows.Forms.Cursors.Default
        Me.UI_About_WwwSylfxNet.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_About_WwwSylfxNet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_About_WwwSylfxNet.Location = New System.Drawing.Point(0, 88)
        Me.UI_About_WwwSylfxNet.Name = "UI_About_WwwSylfxNet"
        Me.UI_About_WwwSylfxNet.Size = New System.Drawing.Size(182, 40)
        Me.UI_About_WwwSylfxNet.TabIndex = 12
        Me.UI_About_WwwSylfxNet.Text = "www.sylfx.net"
        '
        'UI_About_Copyright2013SylvainSIMON
        '
        Me.UI_About_Copyright2013SylvainSIMON.AutoSize = True
        Me.UI_About_Copyright2013SylvainSIMON.Cursor = System.Windows.Forms.Cursors.Default
        Me.UI_About_Copyright2013SylvainSIMON.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_About_Copyright2013SylvainSIMON.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_About_Copyright2013SylvainSIMON.Location = New System.Drawing.Point(0, 48)
        Me.UI_About_Copyright2013SylvainSIMON.Name = "UI_About_Copyright2013SylvainSIMON"
        Me.UI_About_Copyright2013SylvainSIMON.Size = New System.Drawing.Size(365, 40)
        Me.UI_About_Copyright2013SylvainSIMON.TabIndex = 9
        Me.UI_About_Copyright2013SylvainSIMON.Text = "(C)2013-2017 Sylvain SIMON"
        '
        'UI_About_Sylfx3dPureVb
        '
        Me.UI_About_Sylfx3dPureVb.AutoSize = True
        Me.UI_About_Sylfx3dPureVb.Cursor = System.Windows.Forms.Cursors.Default
        Me.UI_About_Sylfx3dPureVb.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_About_Sylfx3dPureVb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_About_Sylfx3dPureVb.Location = New System.Drawing.Point(3, 8)
        Me.UI_About_Sylfx3dPureVb.Name = "UI_About_Sylfx3dPureVb"
        Me.UI_About_Sylfx3dPureVb.Size = New System.Drawing.Size(197, 40)
        Me.UI_About_Sylfx3dPureVb.TabIndex = 8
        Me.UI_About_Sylfx3dPureVb.Text = "3 d P u r e V b"
        '
        'Panel_Light
        '
        Me.Panel_Light.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Panel_Light.Controls.Add(Me.UI_Lightsource_Light)
        Me.Panel_Light.Controls.Add(Me.UI_Lightsource_LightIntensity)
        Me.Panel_Light.Controls.Add(Me.UI_Lightsource_LightZ)
        Me.Panel_Light.Controls.Add(Me.UI_Lightsource_LightY)
        Me.Panel_Light.Controls.Add(Me.UI_Lightsource_LightX)
        Me.Panel_Light.Controls.Add(Me.UI_Lightsource_Intensity)
        Me.Panel_Light.Controls.Add(Me.UI_Lightsource_Z)
        Me.Panel_Light.Controls.Add(Me.UI_Lightsource_Y)
        Me.Panel_Light.Controls.Add(Me.UI_Lightsource_X)
        Me.Panel_Light.Controls.Add(Me.UI_Lightsource_Vector)
        Me.Panel_Light.ForeColor = System.Drawing.Color.Silver
        Me.Panel_Light.Location = New System.Drawing.Point(393, 1)
        Me.Panel_Light.Name = "Panel_Light"
        Me.Panel_Light.Size = New System.Drawing.Size(309, 552)
        Me.Panel_Light.TabIndex = 4
        Me.Panel_Light.Visible = False
        '
        'UI_Lightsource_Light
        '
        Me.UI_Lightsource_Light.AutoSize = True
        Me.UI_Lightsource_Light.Cursor = System.Windows.Forms.Cursors.Default
        Me.UI_Lightsource_Light.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Lightsource_Light.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Lightsource_Light.Location = New System.Drawing.Point(0, 8)
        Me.UI_Lightsource_Light.Name = "UI_Lightsource_Light"
        Me.UI_Lightsource_Light.Size = New System.Drawing.Size(117, 40)
        Me.UI_Lightsource_Light.TabIndex = 8
        Me.UI_Lightsource_Light.Text = "Lighting"
        '
        'UI_Lightsource_LightIntensity
        '
        Me.UI_Lightsource_LightIntensity.AcceptsTab = True
        Me.UI_Lightsource_LightIntensity.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UI_Lightsource_LightIntensity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UI_Lightsource_LightIntensity.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!)
        Me.UI_Lightsource_LightIntensity.ForeColor = System.Drawing.Color.Teal
        Me.UI_Lightsource_LightIntensity.Location = New System.Drawing.Point(214, 354)
        Me.UI_Lightsource_LightIntensity.Name = "UI_Lightsource_LightIntensity"
        Me.UI_Lightsource_LightIntensity.Size = New System.Drawing.Size(68, 39)
        Me.UI_Lightsource_LightIntensity.TabIndex = 18
        Me.UI_Lightsource_LightIntensity.Text = "100"
        Me.UI_Lightsource_LightIntensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'UI_Lightsource_LightZ
        '
        Me.UI_Lightsource_LightZ.AcceptsTab = True
        Me.UI_Lightsource_LightZ.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UI_Lightsource_LightZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UI_Lightsource_LightZ.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!)
        Me.UI_Lightsource_LightZ.ForeColor = System.Drawing.Color.Teal
        Me.UI_Lightsource_LightZ.Location = New System.Drawing.Point(214, 274)
        Me.UI_Lightsource_LightZ.Name = "UI_Lightsource_LightZ"
        Me.UI_Lightsource_LightZ.Size = New System.Drawing.Size(68, 39)
        Me.UI_Lightsource_LightZ.TabIndex = 17
        Me.UI_Lightsource_LightZ.Text = "1"
        Me.UI_Lightsource_LightZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'UI_Lightsource_LightY
        '
        Me.UI_Lightsource_LightY.AcceptsTab = True
        Me.UI_Lightsource_LightY.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UI_Lightsource_LightY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UI_Lightsource_LightY.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!)
        Me.UI_Lightsource_LightY.ForeColor = System.Drawing.Color.Teal
        Me.UI_Lightsource_LightY.Location = New System.Drawing.Point(214, 234)
        Me.UI_Lightsource_LightY.Name = "UI_Lightsource_LightY"
        Me.UI_Lightsource_LightY.Size = New System.Drawing.Size(68, 39)
        Me.UI_Lightsource_LightY.TabIndex = 16
        Me.UI_Lightsource_LightY.Text = "0"
        Me.UI_Lightsource_LightY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'UI_Lightsource_LightX
        '
        Me.UI_Lightsource_LightX.AcceptsTab = True
        Me.UI_Lightsource_LightX.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UI_Lightsource_LightX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UI_Lightsource_LightX.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!)
        Me.UI_Lightsource_LightX.ForeColor = System.Drawing.Color.Teal
        Me.UI_Lightsource_LightX.Location = New System.Drawing.Point(214, 194)
        Me.UI_Lightsource_LightX.Name = "UI_Lightsource_LightX"
        Me.UI_Lightsource_LightX.Size = New System.Drawing.Size(68, 39)
        Me.UI_Lightsource_LightX.TabIndex = 15
        Me.UI_Lightsource_LightX.Text = "0"
        Me.UI_Lightsource_LightX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'UI_Lightsource_Intensity
        '
        Me.UI_Lightsource_Intensity.AutoSize = True
        Me.UI_Lightsource_Intensity.Cursor = System.Windows.Forms.Cursors.Default
        Me.UI_Lightsource_Intensity.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Lightsource_Intensity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Lightsource_Intensity.Location = New System.Drawing.Point(3, 350)
        Me.UI_Lightsource_Intensity.Name = "UI_Lightsource_Intensity"
        Me.UI_Lightsource_Intensity.Size = New System.Drawing.Size(168, 40)
        Me.UI_Lightsource_Intensity.TabIndex = 14
        Me.UI_Lightsource_Intensity.Text = "Intensity (%)"
        '
        'UI_Lightsource_Z
        '
        Me.UI_Lightsource_Z.AutoSize = True
        Me.UI_Lightsource_Z.Cursor = System.Windows.Forms.Cursors.Default
        Me.UI_Lightsource_Z.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Lightsource_Z.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Lightsource_Z.Location = New System.Drawing.Point(0, 270)
        Me.UI_Lightsource_Z.Name = "UI_Lightsource_Z"
        Me.UI_Lightsource_Z.Size = New System.Drawing.Size(34, 40)
        Me.UI_Lightsource_Z.TabIndex = 12
        Me.UI_Lightsource_Z.Text = "Z"
        '
        'UI_Lightsource_Y
        '
        Me.UI_Lightsource_Y.AutoSize = True
        Me.UI_Lightsource_Y.Cursor = System.Windows.Forms.Cursors.Default
        Me.UI_Lightsource_Y.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Lightsource_Y.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Lightsource_Y.Location = New System.Drawing.Point(0, 230)
        Me.UI_Lightsource_Y.Name = "UI_Lightsource_Y"
        Me.UI_Lightsource_Y.Size = New System.Drawing.Size(33, 40)
        Me.UI_Lightsource_Y.TabIndex = 11
        Me.UI_Lightsource_Y.Text = "Y"
        '
        'UI_Lightsource_X
        '
        Me.UI_Lightsource_X.AutoSize = True
        Me.UI_Lightsource_X.Cursor = System.Windows.Forms.Cursors.Default
        Me.UI_Lightsource_X.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Lightsource_X.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Lightsource_X.Location = New System.Drawing.Point(0, 190)
        Me.UI_Lightsource_X.Name = "UI_Lightsource_X"
        Me.UI_Lightsource_X.Size = New System.Drawing.Size(34, 40)
        Me.UI_Lightsource_X.TabIndex = 10
        Me.UI_Lightsource_X.Text = "X"
        '
        'UI_Lightsource_Vector
        '
        Me.UI_Lightsource_Vector.AutoSize = True
        Me.UI_Lightsource_Vector.Cursor = System.Windows.Forms.Cursors.Default
        Me.UI_Lightsource_Vector.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Lightsource_Vector.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Lightsource_Vector.Location = New System.Drawing.Point(0, 110)
        Me.UI_Lightsource_Vector.Name = "UI_Lightsource_Vector"
        Me.UI_Lightsource_Vector.Size = New System.Drawing.Size(236, 40)
        Me.UI_Lightsource_Vector.TabIndex = 9
        Me.UI_Lightsource_Vector.Text = "Directional vector"
        '
        'Panel_Render
        '
        Me.Panel_Render.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Panel_Render.Controls.Add(Me.UI_Render_NoShading)
        Me.Panel_Render.Controls.Add(Me.UI_Render_WireframeHidenFace)
        Me.Panel_Render.Controls.Add(Me.UI_Render_SolidHQ)
        Me.Panel_Render.Controls.Add(Me.UI_Render_SolidPlusWireframe)
        Me.Panel_Render.Controls.Add(Me.UI_Render_Solid)
        Me.Panel_Render.Controls.Add(Me.UI_Render_Wireframe)
        Me.Panel_Render.Controls.Add(Me.UI_Render_Rendermode)
        Me.Panel_Render.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel_Render.Location = New System.Drawing.Point(379, 0)
        Me.Panel_Render.Name = "Panel_Render"
        Me.Panel_Render.Size = New System.Drawing.Size(309, 552)
        Me.Panel_Render.TabIndex = 5
        Me.Panel_Render.Visible = False
        '
        'UI_Render_NoShading
        '
        Me.UI_Render_NoShading.AutoSize = True
        Me.UI_Render_NoShading.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Render_NoShading.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Render_NoShading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Render_NoShading.Location = New System.Drawing.Point(0, 311)
        Me.UI_Render_NoShading.Name = "UI_Render_NoShading"
        Me.UI_Render_NoShading.Size = New System.Drawing.Size(157, 40)
        Me.UI_Render_NoShading.TabIndex = 14
        Me.UI_Render_NoShading.Text = "NoShading"
        '
        'UI_Render_WireframeHidenFace
        '
        Me.UI_Render_WireframeHidenFace.AutoSize = True
        Me.UI_Render_WireframeHidenFace.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Render_WireframeHidenFace.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Render_WireframeHidenFace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Render_WireframeHidenFace.Location = New System.Drawing.Point(0, 151)
        Me.UI_Render_WireframeHidenFace.Name = "UI_Render_WireframeHidenFace"
        Me.UI_Render_WireframeHidenFace.Size = New System.Drawing.Size(260, 40)
        Me.UI_Render_WireframeHidenFace.TabIndex = 13
        Me.UI_Render_WireframeHidenFace.Text = "Wire + Hiden Faces"
        '
        'UI_Render_SolidHQ
        '
        Me.UI_Render_SolidHQ.AutoSize = True
        Me.UI_Render_SolidHQ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Render_SolidHQ.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Render_SolidHQ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Render_SolidHQ.Location = New System.Drawing.Point(0, 271)
        Me.UI_Render_SolidHQ.Name = "UI_Render_SolidHQ"
        Me.UI_Render_SolidHQ.Size = New System.Drawing.Size(255, 40)
        Me.UI_Render_SolidHQ.TabIndex = 12
        Me.UI_Render_SolidHQ.Text = "Solid HQ (Antialias)"
        '
        'UI_Render_SolidPlusWireframe
        '
        Me.UI_Render_SolidPlusWireframe.AutoSize = True
        Me.UI_Render_SolidPlusWireframe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Render_SolidPlusWireframe.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Render_SolidPlusWireframe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Render_SolidPlusWireframe.Location = New System.Drawing.Point(0, 231)
        Me.UI_Render_SolidPlusWireframe.Name = "UI_Render_SolidPlusWireframe"
        Me.UI_Render_SolidPlusWireframe.Size = New System.Drawing.Size(244, 40)
        Me.UI_Render_SolidPlusWireframe.TabIndex = 11
        Me.UI_Render_SolidPlusWireframe.Text = "Solid + Wireframe"
        '
        'UI_Render_Solid
        '
        Me.UI_Render_Solid.AutoSize = True
        Me.UI_Render_Solid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Render_Solid.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Render_Solid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Render_Solid.Location = New System.Drawing.Point(0, 191)
        Me.UI_Render_Solid.Name = "UI_Render_Solid"
        Me.UI_Render_Solid.Size = New System.Drawing.Size(78, 40)
        Me.UI_Render_Solid.TabIndex = 10
        Me.UI_Render_Solid.Text = "Solid"
        '
        'UI_Render_Wireframe
        '
        Me.UI_Render_Wireframe.AutoSize = True
        Me.UI_Render_Wireframe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_Render_Wireframe.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Render_Wireframe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Render_Wireframe.Location = New System.Drawing.Point(0, 111)
        Me.UI_Render_Wireframe.Name = "UI_Render_Wireframe"
        Me.UI_Render_Wireframe.Size = New System.Drawing.Size(148, 40)
        Me.UI_Render_Wireframe.TabIndex = 9
        Me.UI_Render_Wireframe.Text = "Wireframe"
        '
        'UI_Render_Rendermode
        '
        Me.UI_Render_Rendermode.AutoSize = True
        Me.UI_Render_Rendermode.Cursor = System.Windows.Forms.Cursors.Default
        Me.UI_Render_Rendermode.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!)
        Me.UI_Render_Rendermode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.UI_Render_Rendermode.Location = New System.Drawing.Point(0, 8)
        Me.UI_Render_Rendermode.Name = "UI_Render_Rendermode"
        Me.UI_Render_Rendermode.Size = New System.Drawing.Size(187, 40)
        Me.UI_Render_Rendermode.TabIndex = 8
        Me.UI_Render_Rendermode.Text = "Render mode"
        '
        'Sylfx3dPureVb_SideImage
        '
        Me.Sylfx3dPureVb_SideImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Sylfx3dPureVb_SideImage.BackgroundImage = CType(resources.GetObject("Sylfx3dPureVb_SideImage.BackgroundImage"), System.Drawing.Image)
        Me.Sylfx3dPureVb_SideImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Sylfx3dPureVb_SideImage.Enabled = False
        Me.Sylfx3dPureVb_SideImage.ErrorImage = Nothing
        Me.Sylfx3dPureVb_SideImage.InitialImage = Nothing
        Me.Sylfx3dPureVb_SideImage.Location = New System.Drawing.Point(0, 0)
        Me.Sylfx3dPureVb_SideImage.Name = "Sylfx3dPureVb_SideImage"
        Me.Sylfx3dPureVb_SideImage.Size = New System.Drawing.Size(100, 800)
        Me.Sylfx3dPureVb_SideImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Sylfx3dPureVb_SideImage.TabIndex = 18
        Me.Sylfx3dPureVb_SideImage.TabStop = False
        Me.Sylfx3dPureVb_SideImage.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel_About)
        Me.Controls.Add(Me.Sylfx3dPureVb_SideImage)
        Me.Controls.Add(Me.Panel_MainMenu)
        Me.Controls.Add(Me.Panel_Light)
        Me.Controls.Add(Me.Panel_Render)
        Me.Controls.Add(Me.Panel_Primitive)
        Me.Controls.Add(Me.Canvas)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "3dPureVb"
        CType(Me.Canvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_MainMenu.ResumeLayout(False)
        Me.Panel_MainMenu.PerformLayout()
        Me.Panel_Primitive.ResumeLayout(False)
        Me.Panel_Primitive.PerformLayout()
        Me.Panel_About.ResumeLayout(False)
        Me.Panel_About.PerformLayout()
        Me.Panel_Light.ResumeLayout(False)
        Me.Panel_Light.PerformLayout()
        Me.Panel_Render.ResumeLayout(False)
        Me.Panel_Render.PerformLayout()
        CType(Me.Sylfx3dPureVb_SideImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Canvas As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_MainMenu As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UI_Main_PrimRotation As System.Windows.Forms.Label
    Friend WithEvents UI_Main_PrimPosition As System.Windows.Forms.Label
    Friend WithEvents UI_Main_PrimType As System.Windows.Forms.Label
    Friend WithEvents UI_Main_UserMode As System.Windows.Forms.Label
    Friend WithEvents UI_Main_Perspective As System.Windows.Forms.Label
    Friend WithEvents UI_Main_Zoom As System.Windows.Forms.Label
    Friend WithEvents Panel_Primitive As System.Windows.Forms.Panel
    Friend WithEvents UI_Primitives As System.Windows.Forms.Label
    Friend WithEvents UI_Primitives_Torus As System.Windows.Forms.Label
    Friend WithEvents UI_Primitives_Sphere As System.Windows.Forms.Label
    Friend WithEvents UI_Primitives_Cylinder As System.Windows.Forms.Label
    Friend WithEvents UI_Primitives_Cube As System.Windows.Forms.Label
    Friend WithEvents UI_Main_Light As System.Windows.Forms.Label
    Friend WithEvents UI_Main_Hide As System.Windows.Forms.Label
    Friend WithEvents UI_Main_Render As System.Windows.Forms.Label
    Friend WithEvents Panel_Light As System.Windows.Forms.Panel
    Friend WithEvents UI_Lightsource_Intensity As System.Windows.Forms.Label
    Friend WithEvents UI_Lightsource_Z As System.Windows.Forms.Label
    Friend WithEvents UI_Lightsource_Y As System.Windows.Forms.Label
    Friend WithEvents UI_Lightsource_X As System.Windows.Forms.Label
    Friend WithEvents UI_Lightsource_Vector As System.Windows.Forms.Label
    Friend WithEvents UI_Lightsource_Light As System.Windows.Forms.Label
    Friend WithEvents UI_Lightsource_LightX As System.Windows.Forms.TextBox
    Friend WithEvents UI_Lightsource_LightIntensity As System.Windows.Forms.TextBox
    Friend WithEvents UI_Lightsource_LightZ As System.Windows.Forms.TextBox
    Friend WithEvents UI_Lightsource_LightY As System.Windows.Forms.TextBox
    Friend WithEvents Panel_Render As System.Windows.Forms.Panel
    Friend WithEvents UI_Render_SolidPlusWireframe As System.Windows.Forms.Label
    Friend WithEvents UI_Render_Solid As System.Windows.Forms.Label
    Friend WithEvents UI_Render_Wireframe As System.Windows.Forms.Label
    Friend WithEvents UI_Render_Rendermode As System.Windows.Forms.Label
    Friend WithEvents UI_Main_Quit As System.Windows.Forms.Label
    Friend WithEvents UI_Main_About As System.Windows.Forms.Label
    Friend WithEvents Panel_About As System.Windows.Forms.Panel
    Friend WithEvents UI_About_WwwSylfxNet As System.Windows.Forms.Label
    Friend WithEvents UI_About_Copyright2013SylvainSIMON As System.Windows.Forms.Label
    Friend WithEvents UI_About_Sylfx3dPureVb As System.Windows.Forms.Label
    Friend WithEvents Sylfx3dPureVb_SideImage As System.Windows.Forms.PictureBox
    Friend WithEvents UI_Primitives_Spiral As System.Windows.Forms.Label
    Friend WithEvents UI_Primitives_Glenz As System.Windows.Forms.Label
    Friend WithEvents UI_Render_SolidHQ As System.Windows.Forms.Label
    Friend WithEvents UI_Main_DemoMode As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents UI_Render_WireframeHidenFace As System.Windows.Forms.Label
    Friend WithEvents UI_Render_NoShading As System.Windows.Forms.Label

End Class
