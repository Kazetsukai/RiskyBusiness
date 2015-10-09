define(['ko', 'risk-list'], function (ko, risks) {
	return function () {
		var self = {};

		self.loaded = null;

		self.riskId = ko.observable(null);
		self.descripton = ko.observable(null);
		self.category = ko.observable(null);
		self.raisedBy = ko.observable(null);
		self.dateRaised = ko.observable(null);
		self.lastReviewDate = ko.observable(null);
		self.nextReviewDate = ko.observable(null);
		self.owner = ko.observable(null);
		self.status = ko.observable(null);
		self.programRefs = ko.observable(null);
		self.comments = ko.observable(null);
		self.mitigation = ko.observable(null);

		self.preRiskImpact = ko.observable(null);
		self.preRiskProbability = ko.observable(null);
		self.preRiskLevel = ko.observable(null);
		self.postRiskImpact = ko.observable(null);
		self.postRiskProbability = ko.observable(null);
		self.postRiskLevel = ko.observable(null);

		self.save = function () {
			self.loaded.riskId(self.riskId());
			self.loaded.descripton(self.descripton());
			self.loaded.category(self.category());
			self.loaded.raisedBy(self.raisedBy());
			self.loaded.dateRaised(self.dateRaised());
			self.loaded.lastReviewDate(self.lastReviewDate());
			self.loaded.nextReviewDate(self.nextReviewDate());
			self.loaded.owner(self.owner());
			self.loaded.status(self.status());
			self.loaded.programRefs(self.programRefs());
			self.loaded.comments(self.comments());
			self.loaded.mitigation(self.mitigation());

			self.loaded.preRiskImpact(self.preRiskImpact());
			self.loaded.preRiskProbability(self.preRiskProbability());
			self.loaded.preRiskLevel(self.preRiskLevel());
			self.loaded.postRiskImpact(self.postRiskImpact());
			self.loaded.postRiskProbability(self.postRiskProbability());
			self.loaded.postRiskLevel(self.postRiskLevel());

			//clear?

		};

		self.load = function (risk) {
			self.loaded = risk;

			self.riskId(risk.riskId());
			self.descripton(risk.descripton());
			self.category(risk.category());
			self.raisedBy(risk.raisedBy());
			self.dateRaised(risk.dateRaised());
			self.lastReviewDate(risk.lastReviewDate());
			self.nextReviewDate(risk.nextReviewDate());
			self.owner(risk.owner());
			self.status(risk.status());
			self.programRefs(risk.programRefs());
			self.comments(risk.comments());
			self.mitigation(risk.mitigation());

			self.preRiskImpact(risk.preRiskImpact());
			self.preRiskProbability(risk.preRiskProbability());
			self.preRiskLevel(risk.preRiskLevel());
			self.postRiskImpact(risk.postRiskImpact());
			self.postRiskProbability(risk.postRiskProbability());
			self.postRiskLevel(risk.postRiskLevel());
		};

		ko.applyBindings(self, document.getElementById('risk-details'));

		return self;
	};
});