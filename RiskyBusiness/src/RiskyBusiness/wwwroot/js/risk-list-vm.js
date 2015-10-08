define(['ko', 'risk-list'], function (ko, risks) {
	return function () {
		var self = {};

		self.risks = ko.observableArray(risks);

		ko.applyBindings(self, document.getElementsByClassName('risks-list-table')[0]);
	};
});