using System.Reflection;
using static WinFormsApp1.Program;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Type> doctors;
        private Type selectedType;
        private object selectedObject;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            Assembly assembly = Assembly.LoadFrom("C:\\Users\\Mert Can\\source\\repos\\WinFormsApp1\\MyLibrary");
            Type interfaceType = typeof(IArayuz);

            List<string> classes = new List<string>();
            doctors = assembly.GetTypes()
                .Where(t => typeof(IDoctor).IsAssignableFrom(t) && !t.IsInterface)
                .ToList();
            foreach (Type type in doctors)
            {
                doctorsComboBox.Items.Add(type.Name);
            }
            foreach (string className in classes) { Console.WriteLine(classes); }

        }
        private void selectedIndexChanged(object sender, EventArgs e)
        {
            selectedType = doctors[doctorsComboBox.SelectedIndex];
            selectedObject = Activator.CreateInstance(selectedType);
            methodComboBox.Items.Clear();
            parameterTextBox.Text = "";
            resultLabel.Text = "";
            MethodInfo[] methods = selectedType.GetMethods();
            foreach (MethodInfo method in methods)
            {
                methodComboBox.Items.Add(method.Name);
            }
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            if (selectedObject == null || methodComboBox.SelectedItem == null)
            {
                return;
            }
            string methodName = methodComboBox.SelectedItem.ToString();
            MethodInfo method = selectedType.GetMethod(methodName);
            ParameterInfo[] parameters = method.GetParameters();
            object[] methodParameters = new object[parameters.Length];
            if (parameters.Length > 0)
            {
                string parameterValue = parameterTextBox.Text;
                for (int i = 0; i < parameters.Length; i++)
                {
                    ParameterInfo parameter = parameters[i];

                    try
                    {
                        methodParameters[i] = Convert.ChangeType(parameterValue, parameter.ParameterType);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Неверный формат параметра");
                        return;
                    }
                }
            }
            object result = method.Invoke(selectedObject, methodParameters);

            resultLabel.Text = "Результат: " + result.ToString();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}