using System;

class AuditLog
{
    public string ClassName { get; set; }
    public string MethodName { get; set; }
    public string Action { get; set; }
    public DateTime Timestamp { get; set; }
}
