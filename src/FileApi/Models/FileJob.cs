using Shared.Contracts;

namespace FileApi.Models;

public class FileJob
{
    public Guid Id { get; set; }
    public string FileName { get; set; } = string.Empty;
    public string StoredPath { get; set; } = string.Empty;
    public long FileSizeBytes { get; set; }
    public FileJobStatus Status { get; set; } = FileJobStatus.Pending;
    public string? ResultSummary { get; set; }
    public string? ErrorMessage { get; set; }
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? CompletedAtUtc { get; set; }
}
