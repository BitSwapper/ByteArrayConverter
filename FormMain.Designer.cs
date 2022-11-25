namespace ByteArrayConverter;

partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if(disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    void InitializeComponent()
    {
            this.textBoxRawHex = new System.Windows.Forms.TextBox();
            this.textBoxSpacedString = new System.Windows.Forms.TextBox();
            this.textBoxStringLiteral = new System.Windows.Forms.TextBox();
            this.textBoxByteArray = new System.Windows.Forms.TextBox();
            this.buttonCopyRawHex = new System.Windows.Forms.Button();
            this.buttonCopySpacedString = new System.Windows.Forms.Button();
            this.buttonCopyStringLiteral = new System.Windows.Forms.Button();
            this.buttonCopyByteArray = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDoConversion = new System.Windows.Forms.Button();
            this.buttonPasteInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRawHex
            // 
            this.textBoxRawHex.Location = new System.Drawing.Point(118, 100);
            this.textBoxRawHex.Name = "textBoxRawHex";
            this.textBoxRawHex.Size = new System.Drawing.Size(457, 23);
            this.textBoxRawHex.TabIndex = 0;
            // 
            // textBoxSpacedString
            // 
            this.textBoxSpacedString.Location = new System.Drawing.Point(118, 129);
            this.textBoxSpacedString.Name = "textBoxSpacedString";
            this.textBoxSpacedString.Size = new System.Drawing.Size(457, 23);
            this.textBoxSpacedString.TabIndex = 1;
            // 
            // textBoxStringLiteral
            // 
            this.textBoxStringLiteral.Location = new System.Drawing.Point(118, 158);
            this.textBoxStringLiteral.Name = "textBoxStringLiteral";
            this.textBoxStringLiteral.Size = new System.Drawing.Size(457, 23);
            this.textBoxStringLiteral.TabIndex = 2;
            // 
            // textBoxByteArray
            // 
            this.textBoxByteArray.Location = new System.Drawing.Point(118, 187);
            this.textBoxByteArray.Name = "textBoxByteArray";
            this.textBoxByteArray.Size = new System.Drawing.Size(457, 23);
            this.textBoxByteArray.TabIndex = 3;
            // 
            // buttonCopyRawHex
            // 
            this.buttonCopyRawHex.Location = new System.Drawing.Point(581, 99);
            this.buttonCopyRawHex.Name = "buttonCopyRawHex";
            this.buttonCopyRawHex.Size = new System.Drawing.Size(19, 23);
            this.buttonCopyRawHex.TabIndex = 5;
            this.buttonCopyRawHex.Text = "C";
            this.buttonCopyRawHex.UseVisualStyleBackColor = true;
            this.buttonCopyRawHex.Click += new System.EventHandler(this.buttonCopyRawHex_Click);
            // 
            // buttonCopySpacedString
            // 
            this.buttonCopySpacedString.Location = new System.Drawing.Point(581, 128);
            this.buttonCopySpacedString.Name = "buttonCopySpacedString";
            this.buttonCopySpacedString.Size = new System.Drawing.Size(19, 23);
            this.buttonCopySpacedString.TabIndex = 6;
            this.buttonCopySpacedString.Text = "C";
            this.buttonCopySpacedString.UseVisualStyleBackColor = true;
            this.buttonCopySpacedString.Click += new System.EventHandler(this.buttonCopySpacedString_Click);
            // 
            // buttonCopyStringLiteral
            // 
            this.buttonCopyStringLiteral.Location = new System.Drawing.Point(581, 157);
            this.buttonCopyStringLiteral.Name = "buttonCopyStringLiteral";
            this.buttonCopyStringLiteral.Size = new System.Drawing.Size(19, 23);
            this.buttonCopyStringLiteral.TabIndex = 7;
            this.buttonCopyStringLiteral.Text = "C";
            this.buttonCopyStringLiteral.UseVisualStyleBackColor = true;
            this.buttonCopyStringLiteral.Click += new System.EventHandler(this.buttonCopyStringLiteral_Click);
            // 
            // buttonCopyByteArray
            // 
            this.buttonCopyByteArray.Location = new System.Drawing.Point(581, 187);
            this.buttonCopyByteArray.Name = "buttonCopyByteArray";
            this.buttonCopyByteArray.Size = new System.Drawing.Size(19, 23);
            this.buttonCopyByteArray.TabIndex = 8;
            this.buttonCopyByteArray.Text = "C";
            this.buttonCopyByteArray.UseVisualStyleBackColor = true;
            this.buttonCopyByteArray.Click += new System.EventHandler(this.buttonCopyByteArray_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Raw Hex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Spaced String";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "String Literal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Byte Array";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(118, 12);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(457, 23);
            this.textBoxInput.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Input";
            // 
            // buttonDoConversion
            // 
            this.buttonDoConversion.Location = new System.Drawing.Point(10, 49);
            this.buttonDoConversion.Name = "buttonDoConversion";
            this.buttonDoConversion.Size = new System.Drawing.Size(103, 28);
            this.buttonDoConversion.TabIndex = 17;
            this.buttonDoConversion.Text = "Convert";
            this.buttonDoConversion.UseVisualStyleBackColor = true;
            this.buttonDoConversion.Click += new System.EventHandler(this.buttonDoConversion_Click);
            // 
            // buttonPasteInput
            // 
            this.buttonPasteInput.Location = new System.Drawing.Point(94, 12);
            this.buttonPasteInput.Name = "buttonPasteInput";
            this.buttonPasteInput.Size = new System.Drawing.Size(19, 23);
            this.buttonPasteInput.TabIndex = 18;
            this.buttonPasteInput.Text = "P";
            this.buttonPasteInput.UseVisualStyleBackColor = true;
            this.buttonPasteInput.Click += new System.EventHandler(this.buttonPasteInput_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 227);
            this.Controls.Add(this.buttonPasteInput);
            this.Controls.Add(this.buttonDoConversion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCopyByteArray);
            this.Controls.Add(this.buttonCopyStringLiteral);
            this.Controls.Add(this.buttonCopySpacedString);
            this.Controls.Add(this.buttonCopyRawHex);
            this.Controls.Add(this.textBoxByteArray);
            this.Controls.Add(this.textBoxStringLiteral);
            this.Controls.Add(this.textBoxSpacedString);
            this.Controls.Add(this.textBoxRawHex);
            this.Name = "FormMain";
            this.Text = "Byte Array Converter By SleepyHex";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    TextBox textBoxRawHex;
    TextBox textBoxSpacedString;
    TextBox textBoxStringLiteral;
    TextBox textBoxByteArray;
    Button buttonCopyRawHex;
    Button buttonCopySpacedString;
    Button buttonCopyStringLiteral;
    Button buttonCopyByteArray;
    Label label1;
    Label label2;
    Label label3;
    Label label4;
    TextBox textBoxInput;
    Label label6;
    Button buttonDoConversion;
    private Button buttonPasteInput;
}
