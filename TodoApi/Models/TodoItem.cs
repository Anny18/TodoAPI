namespace TodoApi.Models
{
    /// <summary>
    /// add by zhao.yanqin
    /// 当创建一个TodoItem数据库自动生成Id
    /// </summary>
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
