define(['ko', 'risk-list'], function (ko, risks) {
	return function (detailsVM) {
		var self = {};

		self.headers = [
			{ title: 'Risk Id', sortKey: 'id', sorted: ko.observable(false) },
			{ title: 'Description', sortKey: 'desc', sorted: ko.observable(false) },
			{ title: 'Mitigation', sortKey: 'mitigation', sorted: ko.observable(false) },
			{ title: 'Date', sortKey: 'date', sorted: ko.observable(false) },
			{ title: 'Level', sortKey: 'level', sorted: ko.observable(false) }
		];

		var sortFunc = function (a, b) {
			return a < b ? -1 : a > b ? 1 : a == b ? 0 : 0;
		};

		self.currentlySorted = null;

		self.sort = function (header, event) {
			var sortKey = header.sortKey;

			switch (sortKey) {
				case 'id':
					self.risks.sort(function (a, b) {
						return sortFunc(a.riskId(), b.riskId());
					});
					break;
				case 'desc':
					self.risks.sort(function (a, b) {
						return sortFunc(a.descripton(), b.descripton());
					});
					break;
				case 'mitigation':
					self.risks.sort(function (a, b) {
						return sortFunc(a.mitigation(), b.mitigation());
					});
					break;
				case 'date':
					self.risks.sort(function (a, b) {
						return sortFunc(a.dateRaised(), b.dateRaised());
					});
					break;
				case 'level':
					self.risks.sort(function (a, b) {
						return sortFunc(a.preRiskLevel(), b.preRiskLevel());
					});
					break;
			}

			//update status
			if (self.currentlySorted != null) {
				self.currentlySorted.sorted(false);
			}
			self.currentlySorted = header;
			self.currentlySorted.sorted(true);
		};

		self.risks = risks;

		self.edit = function (risk) {
			detailsVM.load(risk);
		};

		ko.applyBindings(self, document.getElementsByClassName('risks-list-table')[0]);
	};
});