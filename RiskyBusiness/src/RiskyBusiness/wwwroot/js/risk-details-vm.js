﻿define(['ko', 'risk-list'], function (ko, risks) {
	return function () {
		var self = {};

		self.loaded = null;

		self.riskId = ko.observable(' ');
		self.descripton = ko.observable(' ');
		self.category = ko.observable(' ');
		self.raisedBy = ko.observable(' ');
		self.dateRaised = ko.observable(' ');
		self.lastReviewDate = ko.observable(' ');
		self.nextReviewDate = ko.observable(' ');
		self.owner = ko.observable(' ');
		self.status = ko.observable(' ');
		self.programRefs = ko.observable(' ');
		self.comments = ko.observable(' ');
		self.mitigation = ko.observable(' ');

		self.preRiskImpact = ko.observable(0);
		self.preRiskProbability = ko.observable(0);
		self.preRiskLevel = ko.observable(0);
		self.postRiskImpact = ko.observable(0);
		self.postRiskProbability = ko.observable(0);
		self.postRiskLevel = ko.observable(0);

		var array = ['Low', 'Medium', 'High'];

		var words = new Array("Low", "Moderate", "High", "Extreme", "Extreme");

		var convertToInt = function (rawr) {
			return array.indexOf(rawr) + 1;
		};

		var convertToString = function (rawr) {
			return array[rawr - 1];
		};

		var convertToWords = function (rawr) {
			return words[rawr - 1];
		};

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

			self.loaded.preRiskImpact(convertToString(self.preRiskImpact()));
			self.loaded.preRiskProbability(convertToString(self.preRiskProbability()));
			self.loaded.postRiskImpact(convertToString(self.postRiskImpact()));
			self.loaded.postRiskProbability(convertToString(self.postRiskProbability()));

			self.loaded.preRiskLevel(convertToWords((self.preRiskImpact() - 1) + (self.preRiskProbability() - 1)));
			self.loaded.postRiskLevel(convertToWords((self.postRiskImpact() - 1) + (self.postRiskProbability() - 1)));

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

			self.preRiskImpact(convertToInt(risk.preRiskImpact()));
			self.preRiskProbability(convertToInt(risk.preRiskProbability()));
			self.postRiskImpact(convertToInt(risk.postRiskImpact()));
			self.postRiskProbability(convertToInt(risk.postRiskProbability()));

			self.preRiskLevel((self.preRiskImpact() - 1) + (self.preRiskProbability() - 1));
			self.postRiskLevel((self.postRiskImpact() - 1) + (self.postRiskProbability() - 1));
		};

		ko.applyBindings(self, document.getElementById('risk-details'));

		return self;
	};
});