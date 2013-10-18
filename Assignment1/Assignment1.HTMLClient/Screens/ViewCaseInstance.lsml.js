/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.ViewCaseInstance.AddVote_execute = function (screen) {
    // Write code here.
    screen.CaseInstance.VotesFor = screen.CaseInstance.VotesFor + 1;
        
};
myapp.ViewCaseInstance.AddVoteAgainst_execute = function (screen) {
    // Write code here.
    screen.CaseInstance.VotesAgainst = screen.CaseInstance.VotesAgainst + 1;
};