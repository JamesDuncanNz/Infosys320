/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.CaseInstance.created = function (entity) {
    // Write code here.
    entity.Tree = new myapp.Tree()
    entity.VotesAgainst = 0;
    entity.VotesFor = 0;
};