using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBlogFitness.BL.Model
{
    [Serializable]
    public class Exercise
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Activity Activity { get; set; }
        public User User { get; }
        public Exercise(DateTime start,DateTime finish, Activity activity, User user)
        {
            // Проверка
            Start = start;
            Finish = finish;
            Activity = activity;
            User = user;
        }

    }
}
