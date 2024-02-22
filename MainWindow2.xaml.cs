using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace p2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<DateTime, List<Note>> notes = new Dictionary<DateTime, List<Note>>();
        private string notesFilePath = "notes.json";

        public MainWindow()
        {
            InitializeComponent();
            noteDatePicker.SelectedDate = DateTime.Today;
            LoadNotes();
            UpdateNoteListBox(DateTime.Today);
        }

        public class Note
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }

        private void noteDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime selectedDate = noteDatePicker.SelectedDate ?? DateTime.Today;
            UpdateNoteListBox(selectedDate);
        }

        private void LoadNotes()
        {
            if (File.Exists(notesFilePath))
            {
                string json = File.ReadAllText(notesFilePath);
                notes = JsonConvert.DeserializeObject<Dictionary<DateTime, List<Note>>>(json);
            }
        }

        private void SaveNotes()
        {
            string json = JsonConvert.SerializeObject(notes);
            File.WriteAllText(notesFilePath, json);
        }

        private void UpdateNoteListBox(DateTime selectedDate)
        {
            if (notes.ContainsKey(selectedDate))
            {
                noteListBox.ItemsSource = notes[selectedDate];
            }
            else
            {
                noteListBox.ItemsSource = null;
            }
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime selectedDate = calendar.SelectedDate ?? DateTime.Today;
            UpdateNoteListBox(selectedDate);
        }

        private void NoteListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (noteListBox.SelectedItem is Note selectedNote)
            {
                noteTitleTextBox.Text = selectedNote.Title;
                noteDescriptionTextBox.Text = selectedNote.Description;
            }
        }

        private void AddNote_Click(object sender, RoutedEventArgs e)
        {
            DateTime selectedDate = calendar.SelectedDate ?? DateTime.Today;
            if (!notes.ContainsKey(selectedDate))
            {
                notes[selectedDate] = new List<Note>();
            }
            notes[selectedDate].Add(new Note { Title = noteTitleTextBox.Text, Description = noteDescriptionTextBox.Text });
            SaveNotes();
            UpdateNoteListBox(selectedDate);
        }

        private void EditNote_Click(object sender, RoutedEventArgs e)
        {
            if (noteListBox.SelectedItem is Note selectedNote)
            {
                selectedNote.Title = noteTitleTextBox.Text;
                selectedNote.Description = noteDescriptionTextBox.Text;
                SaveNotes();
                UpdateNoteListBox(calendar.SelectedDate ?? DateTime.Today);
            }
        }

        private void DeleteNote_Click(object sender, RoutedEventArgs e)
        {
            if (noteListBox.SelectedItem is Note selectedNote)
            {
                DateTime selectedDate = calendar.SelectedDate ?? DateTime.Today;
                notes[selectedDate].Remove(selectedNote);
                SaveNotes();
                UpdateNoteListBox(selectedDate);
            }
        }
    }

   
}

