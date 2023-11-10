namespace WebApplication1
{
    public static class AllTasks
    {
        public static List<TaskModel> allTasks = new List<TaskModel>{

        new TaskModel(1, "fff","Orange", DateTime.Now,Preferance.a),
        new TaskModel(2,"sss","Orange", DateTime.Now,Preferance.a),
        new TaskModel(3, "ggg","Orange", DateTime.Now,Preferance.a),
        new TaskModel(4, "yyy","Orange", DateTime.Now,Preferance.a),
        new TaskModel(1, "ppp","purple", DateTime.Now,Preferance.a),
        new TaskModel(2,"lll","yellow", DateTime.Now,Preferance.a),
        new TaskModel(3, "kkk","pink", DateTime.Now,Preferance.a),
        new TaskModel(4, "mmm","red", DateTime.Now,Preferance.a)
        };
    }
}
