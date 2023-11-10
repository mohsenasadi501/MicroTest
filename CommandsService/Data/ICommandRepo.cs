using CommandsService.Models;
namespace CommandsService.Data
{
    public interface ICommandRepo
    {
        bool SaveChnages();

        //Platform
        IEnumerable<Platform> GetAllPlatforms();
        void CreatePlatform(Platform platform);
        bool PlatfromExists(int platformId);
        bool ExternalPlatformExists(int externalPlatformId);

        //Command
        IEnumerable<Command> GetCommandsForPlatform(int platformId);
        Command GetCommand(int platformId, int commandId);
        void CreateCommand(int platformId, Command command);
    }
}
