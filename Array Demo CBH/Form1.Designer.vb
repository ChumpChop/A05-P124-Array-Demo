﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstFriends = New System.Windows.Forms.ListBox()
        Me.btnArrayElement = New System.Windows.Forms.Button()
        Me.btnEnumerateArray = New System.Windows.Forms.Button()
        Me.btnArraysAsParameters = New System.Windows.Forms.Button()
        Me.btnMoreArrayParameters = New System.Windows.Forms.Button()
        Me.btnSortingArrays = New System.Windows.Forms.Button()
        Me.btnReversingAnArray = New System.Windows.Forms.Button()
        Me.btnInitializingArraysWithValues = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstFriends
        '
        Me.lstFriends.FormattingEnabled = True
        Me.lstFriends.IntegralHeight = False
        Me.lstFriends.Location = New System.Drawing.Point(13, 13)
        Me.lstFriends.Name = "lstFriends"
        Me.lstFriends.Size = New System.Drawing.Size(221, 420)
        Me.lstFriends.TabIndex = 0
        '
        'btnArrayElement
        '
        Me.btnArrayElement.Location = New System.Drawing.Point(240, 12)
        Me.btnArrayElement.Name = "btnArrayElement"
        Me.btnArrayElement.Size = New System.Drawing.Size(163, 23)
        Me.btnArrayElement.TabIndex = 1
        Me.btnArrayElement.Text = "Array Element"
        Me.btnArrayElement.UseVisualStyleBackColor = True
        '
        'btnEnumerateArray
        '
        Me.btnEnumerateArray.Location = New System.Drawing.Point(240, 41)
        Me.btnEnumerateArray.Name = "btnEnumerateArray"
        Me.btnEnumerateArray.Size = New System.Drawing.Size(163, 23)
        Me.btnEnumerateArray.TabIndex = 2
        Me.btnEnumerateArray.Text = "Enumerate Array"
        Me.btnEnumerateArray.UseVisualStyleBackColor = True
        '
        'btnArraysAsParameters
        '
        Me.btnArraysAsParameters.Location = New System.Drawing.Point(240, 70)
        Me.btnArraysAsParameters.Name = "btnArraysAsParameters"
        Me.btnArraysAsParameters.Size = New System.Drawing.Size(163, 23)
        Me.btnArraysAsParameters.TabIndex = 3
        Me.btnArraysAsParameters.Text = "Arrays as Parameters"
        Me.btnArraysAsParameters.UseVisualStyleBackColor = True
        '
        'btnMoreArrayParameters
        '
        Me.btnMoreArrayParameters.Location = New System.Drawing.Point(241, 100)
        Me.btnMoreArrayParameters.Name = "btnMoreArrayParameters"
        Me.btnMoreArrayParameters.Size = New System.Drawing.Size(162, 23)
        Me.btnMoreArrayParameters.TabIndex = 4
        Me.btnMoreArrayParameters.Text = "More Array Parameters."
        Me.btnMoreArrayParameters.UseVisualStyleBackColor = True
        '
        'btnSortingArrays
        '
        Me.btnSortingArrays.Location = New System.Drawing.Point(241, 130)
        Me.btnSortingArrays.Name = "btnSortingArrays"
        Me.btnSortingArrays.Size = New System.Drawing.Size(162, 23)
        Me.btnSortingArrays.TabIndex = 5
        Me.btnSortingArrays.Text = "Sorting Arrays"
        Me.btnSortingArrays.UseVisualStyleBackColor = True
        '
        'btnReversingAnArray
        '
        Me.btnReversingAnArray.Location = New System.Drawing.Point(241, 160)
        Me.btnReversingAnArray.Name = "btnReversingAnArray"
        Me.btnReversingAnArray.Size = New System.Drawing.Size(162, 23)
        Me.btnReversingAnArray.TabIndex = 6
        Me.btnReversingAnArray.Text = "Reversing an Array"
        Me.btnReversingAnArray.UseVisualStyleBackColor = True
        '
        'btnInitializingArraysWithValues
        '
        Me.btnInitializingArraysWithValues.Location = New System.Drawing.Point(241, 189)
        Me.btnInitializingArraysWithValues.Name = "btnInitializingArraysWithValues"
        Me.btnInitializingArraysWithValues.Size = New System.Drawing.Size(162, 23)
        Me.btnInitializingArraysWithValues.TabIndex = 7
        Me.btnInitializingArraysWithValues.Text = "Initializing Arrays with Values"
        Me.btnInitializingArraysWithValues.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnInitializingArraysWithValues)
        Me.Controls.Add(Me.btnReversingAnArray)
        Me.Controls.Add(Me.btnSortingArrays)
        Me.Controls.Add(Me.btnMoreArrayParameters)
        Me.Controls.Add(Me.btnArraysAsParameters)
        Me.Controls.Add(Me.btnEnumerateArray)
        Me.Controls.Add(Me.btnArrayElement)
        Me.Controls.Add(Me.lstFriends)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstFriends As ListBox
    Friend WithEvents btnArrayElement As Button
    Friend WithEvents btnEnumerateArray As Button
    Friend WithEvents btnArraysAsParameters As Button
    Friend WithEvents btnMoreArrayParameters As Button
    Friend WithEvents btnSortingArrays As Button
    Friend WithEvents btnReversingAnArray As Button
    Friend WithEvents btnInitializingArraysWithValues As Button
End Class
