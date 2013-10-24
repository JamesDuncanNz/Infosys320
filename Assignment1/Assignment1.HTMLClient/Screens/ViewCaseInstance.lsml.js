/// <reference path="../GeneratedArtifacts/viewModel.js" />
var mapDiv;
var current = 0;
var step = 15;

myapp.ViewCaseInstance.AddVote_execute = function (screen) {
    // Write code here.
    screen.CaseInstance.VotesFor = screen.CaseInstance.VotesFor + 1;
        
};
myapp.ViewCaseInstance.AddVoteAgainst_execute = function (screen) {
    // Write code here.
    screen.CaseInstance.VotesAgainst = screen.CaseInstance.VotesAgainst + 1;
};

myapp.ViewCaseInstance.Map_render = function (element, contentItem) {
    mapDiv = $('<div />').appendTo($(element));
    $(mapDiv).lightswitchBingMapsControl();    
};
