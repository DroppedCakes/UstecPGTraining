using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingTraining.Models
{
    /// <summary>
    /// Shell(MainWindow)のTitleのModel
    /// </summary>
    public class TitleMessenger : BindableBase
    {
        private string title = "PRISM APP";
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        public TitleMessenger()
        {
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="title"></param>
        public void ChangeTitle(string title)
        {
            this.Title = title;
        }
    }
}
