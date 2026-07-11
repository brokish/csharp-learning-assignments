using Assigment_10.MainAppLogics;
using Homework.Helpers;


SharedUtils.InitializeConsole();

StorageApp storageApp = new StorageApp();
StudentReporter studentReporter = new StudentReporter();
UserApp userApp = new UserApp();

// storageApp.Run();
// studentReporter.Run();
userApp.Run();