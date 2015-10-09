define(['ko', 'risks-raw'], function (ko, rawRisks) {

	var obsRisks = rawRisks.map(function (risk) {
		var observableRisk = {};

		observableRisk.riskId = ko.observable(risk.risk_key);
		observableRisk.descripton = ko.observable(risk.risk_descr);
		observableRisk.category = ko.observable(risk.category);
		observableRisk.mitigation = ko.observable(risk.mitigation_plan);
		observableRisk.raisedBy = ko.observable(risk.raised_by);
		observableRisk.dateRaised = ko.observable(risk.date_raised);
		observableRisk.preRiskImpact = ko.observable(risk.pre_mitigation_impact);
		observableRisk.preRiskProbability = ko.observable(risk.pre_mitigation_probability);
		observableRisk.preRiskLevel = ko.observable(risk.pre_mitigation_risk_level);
		observableRisk.postRiskImpact = ko.observable(risk.post_mitigation_impact);
		observableRisk.postRiskProbability = ko.observable(risk.post_mitigation_probability);
		observableRisk.postRiskLevel = ko.observable(risk.post_mitigation_risk_level);
		observableRisk.dateRaised = ko.observable(risk.date_raised);
		observableRisk.lastReviewDate = ko.observable(risk.last_review_date);
		observableRisk.nextReviewDate = ko.observable(risk.next_review_date);
		observableRisk.owner = ko.observable(risk.owner);
		observableRisk.status = ko.observable(risk.status);
		observableRisk.programRefs = ko.observable(risk.project_task_reference);
		observableRisk.comments = ko.observable(risk.comments);

		//risk.risk_key
		//risk.category
		//risk.comments
		//risk.date_raised
		//risk.last_review_date
		//risk.mitigation_plan
		//risk.next_review_date
		//risk.owner
		//risk.post_mitigation_impact
		//risk.post_mitigation_probability
		//risk.post_mitigation_risk_level
		//risk.pre_mitigation_impact
		//risk.pre_mitigation_probability
		//risk.pre_mitigation_risk_level
		//risk.project_task_reference
		//risk.raised_by
		//risk.risk_descr
		//risk.risk_ref_id
		//risk.status

		return observableRisk;
	});

	return ko.observableArray(obsRisks);
});