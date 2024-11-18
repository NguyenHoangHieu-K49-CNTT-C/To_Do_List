using long_bong_midterm.CustomClasses;

namespace long_bong_midterm
{
    public partial class MainTaskForm : Form
    {
        AppManager appManager;
        public MainTaskForm()
        {
            InitializeComponent();
        }

        private void MainTaskForm_Load(object sender, EventArgs e)
        {
            string[] type = { "No Category", "Work", "Personal" };
            string[] repeat = { "No repeat", "Daily", "Weakly", "Yearly" };
            for (int i = 0;i<24;i++)
                cbbox_hours.Items.Add(i);
            for(int i = 0;i<60;i++)
                cbbox_minutes.Items.Add(i);
            foreach (var s in type)
                cbbox_type.Items.Add(s);
            foreach (var s in repeat)
                cbbox_repeatation.Items.Add(s);

            cbbox_type.SelectedIndex = 0;
            cbbox_repeatation.SelectedIndex = 0;
            cbbox_hours.SelectedIndex = 0;
            cbbox_minutes.SelectedIndex = 0;

            appManager = new AppManager();
            appManager.readTextFile();
            appManager.PopulateListView(liv_all, "All");
            appManager.PopulateListView(liv_work, "Work");
            appManager.PopulateListView(liv_personal, "Personal");
            appManager.PopulateListView(liv_nocatagory, "No catagory");
            
        }

        private void pic_calender_Click(object sender, EventArgs e)
        {
            PickDateForm pickDateForm = new PickDateForm();
            pickDateForm.ShowDialog();
        }

        private void cbbox_repeatation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbox_repeatation.SelectedIndex == 0) txt_repeat.Enabled = false;
            else txt_repeat.Enabled = true;
        }

        
    }
}
