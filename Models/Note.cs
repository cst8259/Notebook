using System;

namespace Notebook.Models;

public class Note
{
  public int Id { get; set; }
  public string Title { get; set; } = string.Empty;
  public string Content { get; set; } = string.Empty;
  public int UserId { get; set; }
  public int CategoryId { get; set; }
}
