using UR_pnach_editor.Views;
using UR_pnach_editor.Services;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UR_pnach_editor.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        internal void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }


        public void DisplayMainView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new MainView();
            });
        }

        public void DisplayStatsView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new StatsView();
            });
        }

        public void DisplayTextureView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new TextureView();
            });
        }

        public void DisplayChallengeView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new ChallengeView();
            });
        }

        public void DisplayCharacterView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new CharacterView();
            });
        }

        public void DisplayDeveloperView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new DeveloperView();
            });
        }

        public void DisplayChallengeModeView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new ChallengeModeView();
            });
        }

        public void DisplayMovesetView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new MovesetView();
            });
        }

        public void DisplayModelsAndMusicView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new ModelsAndMusicView();
            });
        }

        public void DisplayMiscellaneousCheatsView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new MiscellaneousCheatsView();
            });
        }

        public void DisplayMysteriousView()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ProcessingClass.MainWindowFrame.Content = new MysteriousView();
            });
        }

    }
}
