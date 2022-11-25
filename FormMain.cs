namespace ByteArrayConverter;

public partial class FormMain : Form
{
    public FormMain() => InitializeComponent();

    void buttonDoConversion_Click(object sender, EventArgs e)
    {
        List<string> byteList = new();
        try
        {
            ArrayFilter.FilterUserInput(textBoxInput.Text, byteList);
            UpdateUiWithOutput(byteList);
        }
        catch { MessageBox.Show("Invalid Input. Please verify and try again"); }
    }

    void UpdateUiWithOutput(List<string> list)
    {
        textBoxRawHex.Text = string.Join(null, list.ToArray());
        textBoxSpacedString.Text = string.Join(" ", list.ToArray());
        textBoxStringLiteral.Text = @"\x" + string.Join(@"\x", list.ToArray());
        textBoxByteArray.Text = "0x" + string.Join(", 0x", list.ToArray());
    }

    void buttonCopyRawHex_Click(object sender, EventArgs e) => Clipboard.SetText(textBoxRawHex.Text);
    void buttonCopySpacedString_Click(object sender, EventArgs e) => Clipboard.SetText(textBoxSpacedString.Text);
    void buttonCopyStringLiteral_Click(object sender, EventArgs e) => Clipboard.SetText(textBoxStringLiteral.Text);
    void buttonCopyByteArray_Click(object sender, EventArgs e) => Clipboard.SetText(textBoxByteArray.Text);
    void buttonPasteInput_Click(object sender, EventArgs e) => textBoxInput.Text = Clipboard.GetText();
}