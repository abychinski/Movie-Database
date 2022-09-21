using System.Collections.Generic;

namespace MovieDatabase.Services;

/// <summary>
///     This service interface only exists an example.
///     It can either be copied and modified, or deleted.
/// </summary>
public interface IFileService
{
    void Read();
    void Write(int movieId, string movieTitle, string genresString);
    void Display();
    List<int> MovieIds { get; set; }
    List<string> MovieTitles { get; set; }
    List<string> MovieGenres { get; set; }

}
