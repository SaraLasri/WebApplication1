﻿namespace WebApplication1
{
    public static class AllTasks
    {
        public static List<TaskModel> allTasks = new List<TaskModel>{

        new TaskModel(1, "fff","Orange", DateTime.Now,Preferance.a),
        new TaskModel(2,"ggg","Orange", DateTime.Now,Preferance.a),
        new TaskModel(3, "fff","Green", DateTime.Now,Preferance.a),
        new TaskModel(4, "uuu","Orange", DateTime.Now,Preferance.a)
        };
    }
}
