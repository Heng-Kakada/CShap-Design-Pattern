using System;
namespace Bridge_Pattern;

// name: heng kakada 
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private ObjectView objView = null;
    private IObject obj;

    private void Form1_Load(object sender, EventArgs e)
    {
        this.AutoSize = true;
        this.AutoSizeMode = Forms
            //AutoSizeMode.GrowAndShrink;
        panel1.AutoSize = true;
        panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        panel1.Controls.Clear();
        try
        {
            obj = new Rectangle(4.5, 12.8);
            objView = new SingleLineView(obj);
            Panel first = objView.Layout;
            panel1.Controls.Add(first);

            obj = new Student("Heng Kakada", "22", 85.5);
            objView = new FieldView(obj);
            Panel second = objView.Layout;
            panel1.Controls.Add(second);
            second.Top = first.Height + 2;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
