using System.Linq;
using System.Text.RegularExpressions;

namespace CarParkTracker
{
    public partial class Form1 : Form
    {
        private const int MAX_VEHICLES = 100; // Adjust this value as needed
        private List<string> enteringVehicles = new List<string>();
        private List<string> exitingVehicles = new List<string>();



        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Read file content and parse lines
                        string[] lines = File.ReadAllLines(openFileDialog.FileName);

                        foreach (string line in lines)
                        {
                            string rego = line.Trim();
                            if (IsValidRego(rego))
                            {
                                enteringVehicles.Add(rego);
                            }
                        }

                        UpdateListBoxes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error reading file: " + ex.Message);
                    }
                }
            }

        }

        private void buttonAddPlate_Click(object sender, EventArgs e)
        {
            string newRego = textBoxRegoPlate.Text.Trim();

            if (IsValidRego(newRego) && !enteringVehicles.Contains(newRego))
            {
                enteringVehicles.Add(newRego);
                listBoxEnteringVehicles.Items.Add(newRego);
                textBoxRegoPlate.Clear();
            }
            else
            {
                MessageBox.Show("Invalid matrícula format or duplicate detected.");
            }
        }
        private void AddExitingVehicle(string rego)
        {
            if (IsValidRego(rego) && enteringVehicles.Contains(rego))
            {
                enteringVehicles.Remove(rego);
                exitingVehicles.Add(rego);
                UpdateListBoxes();
            }
            else
            {
                MessageBox.Show("Invalid matrícula format or vehicle not found in entering list.");
            }
        }


        private bool IsValidRego(string rego)
        {
            // Regular expression pattern for valid matrícula
            const string regexPattern = @"^[A-Za-z0-9]{1,7}$";
            return Regex.IsMatch(rego, regexPattern);

        }

        private void buttonSavePlate_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Write lists to file
                        File.WriteAllLines(saveFileDialog.FileName, enteringVehicles.Concat(exitingVehicles));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving file: " + ex.Message);
                    }
                }
            }

        }

        private void buttonEditPlate_Click(object sender, EventArgs e)
        {// Get selected index in a single line using null-conditional operator
            int? selectedIndex = listBoxEnteringVehicles.SelectedIndex;
            if (selectedIndex.HasValue) // Check if an item is selected
            {
                string selectedRego = enteringVehicles[selectedIndex.Value];

                listBoxEnteringVehicles.SelectedIndex = -1; // Deselect
                textBoxRegoPlate.Text = selectedRego;

                if (IsValidRego(textBoxRegoPlate.Text) ||
                    (textBoxRegoPlate.Text = !(selectedRego || // Avoids unnecessary search
                     !enteringVehicles.Contains(textBoxRegoPlate.Text, StringComparison.OrdinalIgnoreCase)
                    // Checks for duplicates excluding the selected one
                    )))
                {
                    enteringVehicles[selectedIndex.Value] = textBoxRegoPlate.Text.Trim();
                    listBoxEnteringVehicles.Items[selectedIndex.Value] = textBoxRegoPlate.Text.Trim();
                    textBoxRegoPlate.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid matrícula format or duplicate detected.");
                    listBoxEnteringVehicles.SelectedIndex = selectedIndex.Value; // Reselect
                }
            }
            else
            {
                MessageBox.Show("Please select a matrícula to edit.");
            }
        }
        private void UpdateListBoxes()
        {
            listBoxEnteringVehicles.Items.Clear();
            listBoxExitingVehicles.Items.Clear();

            foreach (string rego in enteringVehicles)
            {
                listBoxEnteringVehicles.Items.Add(rego);
            }

            foreach (string rego in exitingVehicles)
            {
                listBoxExitingVehicles.Items.Add(rego);
            }

        }

        private void buttonDeletePlate_Click(object sender, EventArgs e)
        {
            if (listBoxEnteringVehicles.SelectedIndex >= 0)
            {
                int selectedIndex = listBoxEnteringVehicles.SelectedIndex;
                string selectedRego = enteringVehicles[selectedIndex];

                DialogResult result = MessageBox.Show("Are you sure you want to delete " + selectedRego + "?", "Delete Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    enteringVehicles.RemoveAt(selectedIndex);
                    listBoxEnteringVehicles.Items.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a matrícula to delete.");
            }

        }
        private void RemoveExitingVehicle(string rego)
        {
            if (exitingVehicles.Contains(rego))
            {
                exitingVehicles.Remove(rego);
                UpdateListBoxes();
            }
            else
            {
                MessageBox.Show("Vehicle not found in exiting list.");
            }

        }

        private void buttonBinarySearch_Click(object sender, EventArgs e)
        {
            string regoToFind = textBoxRegoPlate.Text.Trim();

            int index = BinarySearch(regoToFind);

            if (index >= 0)
            {
                MessageBox.Show("Matrícula found at index: " + index);
            }
            else
            {
                MessageBox.Show("Matrícula not found.");
            }
        }

        private void buttonLinearSearch_Click(object sender, EventArgs e)
        {
            string regoToFind = textBoxRegoPlate.Text.Trim();

            int index = LinearSearch(regoToFind);

            if (index >= 0)
            {
                MessageBox.Show("Matrícula found at index: " + index);
            }
            else
            {
                MessageBox.Show("Matrícula not found.");
            }
        }

        private void buttonTagPlate_Click(object sender, EventArgs e)
        {

            // Get selected index and matrícula
            int selectedIndex = listBoxEnteringVehicles.SelectedIndex;

            if (selectedIndex >= 0)
            {
                ToggleTag(selectedIndex);

                // Update UI to indicate tagging (e.g., change color)
                // ...

                MessageBox.Show("Matrícula tagged successfully.");
            }
            else
            {
                MessageBox.Show("Please select a matrícula to tag.");
            }
        }

    
        private int BinarySearch(string rego)
        {
            // Check if list is empty
            if (enteringVehicles.Count == 0)
            {
                return -1;
            }

            // Set initial boundaries
            int low = 0;
            int high = enteringVehicles.Count - 1;

            while (low <= high)
            {
                // Calculate the mid-point
                int mid = low + (high - low) / 2;

                // Compare matrícula with the value at the mid-point
                int comparison = string.Compare(rego, enteringVehicles[mid], StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                {
                    return mid; // Matrícula found
                }
                else if (comparison < 0)
                {
                    high = mid - 1; // Search in the lower half
                }
                else
                {
                    low = mid + 1; // Search in the upper half
                }
            }

            return -1; // Matrícula not found
        }
        private int LinearSearch(string rego)
        {
            for (int i = 0; i < enteringVehicles.Count; i++)
            {
                // Compare matrícula with the value at the current index
                int comparison = string.Compare(rego, enteringVehicles[i], StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                {
                    return i; // Matrícula found
                }
            }

            return -1; // Matrícula not found
        }
        private void SortListForBinarySearch()
        {
            enteringVehicles.Sort(); // Sorts based on default string comparison
        }
        private void ToggleTag(int selectedIndex)
        {
            if (selectedIndex >= 0 && selectedIndex < enteringVehicles.Count)
            {
                string selectedRego = enteringVehicles[selectedIndex];

                // Append "(Tagged)" to matrícula string if not already tagged
                if (!selectedRego.EndsWith(" (Tagged)"))
                {
                    selectedRego += " (Tagged)";
                    enteringVehicles[selectedIndex] = selectedRego; // Update list data
                }
                else
                {
                    // Remove "(Tagged)" from matrícula string if tagged
                    selectedRego = selectedRego.Substring(0, selectedRego.IndexOf(" (Tagged)"));
                    enteringVehicles[selectedIndex] = selectedRego; // Update list data
                }

                // Update UI to visually indicate tagging (e.g., change color of list box item)
                listBoxEnteringVehicles.Items[selectedIndex] = selectedRego;

                MessageBox.Show("Matrícula tagged successfully.");
            }
        }
    }

    
}