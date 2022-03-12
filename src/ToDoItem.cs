using System;


public namespace ToDoItem
{
    public class ToDo
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Notes { get; set; } = "";
        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(2);
    }
}