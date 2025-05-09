namespace DecoratorExample;
using DecoratorExample.mix.sub;

public partial class FormDrinkIntegration : Form
{
    private List<string> data = new List<string> { "water", "sugar", "milk", "coffee" };
    private AbstractDrink d;

    public FormDrinkIntegration()
    {
        InitializeComponent();
        cboIngredient.DataSource = data;
        cboIngredient.SelectedIndex = 0;

        btnMix.Click += DoClickMix;
        btnActivate.Click += DoClickActivate;
    }

    private void DoClickActivate(object? sender, EventArgs e)
    {
        txtDrink.Enabled = true;
        txtMixName.Enabled = true;
        txtWeight.Enabled = true;
        btnMix.Visible = true;
        cboIngredient.Enabled = true;
    }

    private void DoClickMix(object? sender, EventArgs e)
    {
        d.Update(typeof(Drink), txtDrink.Text);
        switch (cboIngredient.Text)
        {
            case "coffee":
                d.Update(typeof(CoffeeMixing), txtMixName.Text, double.Parse(txtWeight.Text));
                break;
            case "sugar":
                d.Update(typeof(SugarMixing), txtMixName.Text, double.Parse(txtWeight.Text));
                break;
            case "water":
                d.Update(typeof(WaterMixing), txtMixName.Text, double.Parse(txtWeight.Text));
                break;
            case "milk":
                d.Update(typeof(MilkMixing), txtMixName.Text, double.Parse(txtWeight.Text));
                break;
        }

        txtResult.Clear();
        Display();

    }

    private void Display()
    {
        this.txtResult.Text = "Name: Heng Kakada" + Environment.NewLine;
        this.txtResult.Text += d.Description;
    }

    private void FormDrinkIntegration_Load(object sender, EventArgs e)
    {
        d = new SugarMixing(
             new CoffeeMixing(
             new MilkMixing(
             new Drink("Second Drink"),
             "My Boy", 3),
            "Mondulkiri", 5),
            "Equal", 2);

        d = new WaterMixing(d, "Evian", 10);
        Display();
    }

}