namespace Shared.Contracts;

public record FileUploadedEvent(
    Guid JobId,
    string FileName,
    string StoredPath,
    DateTime UploadedAtUtc
);
