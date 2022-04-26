
/*
 * Editor client script for DB table vehicles
 * Created by http://editor.datatables.net/generator
 */

(function($){

$(document).ready(function() {
	var editor = new $.fn.dataTable.Editor( {
		ajax: 'php/table.vehicles.php',
		table: '#vehicles',
		fields: [
			{
				"label": "&Eacute;vj&aacute;rat:",
				"name": "prodyear"
			},
			{
				"label": "T&iacute;pus:",
				"name": "type"
			},
			{
				"label": "Motor:",
				"name": "engine",
				"type": "select",
				"options": [
					"1CYL",
					"I2",
					"I3",
					"I4",
					"I6",
					"V2",
					"V3",
					"V4",
					"V6",
					"VR5",
					"VR6",
					"V8",
					"W8",
					"V10",
					"W12",
					"V12",
					"V16",
					"Wankel",
					"Electric",
					"Egy\u00e9b"
				]
			},
			{
				"label": "K&ouml;bcenti:",
				"name": "ccm"
			},
			{
				"label": "&Uuml;zemanyag:",
				"name": "fueltype",
				"type": "select",
				"options": [
					"Benzin",
					"D\u00edzel",
					"Elektromos",
					"Benzin + G\u00e1z",
					"Hibrid (Benzin)",
					"Hibrid (D\u00edzel)",
					"Hidrog\u00e9ncella",
					"Egy\u00e9b"
				]
			},
			{
				"label": "Sz&iacute;n:",
				"name": "color",
				"type": "select",
				"options": [
					"Feh\u00e9r",
					"Fekete",
					"Sz\u00fcrke",
					"Ez\u00fcst",
					"K\u00e9k",
					"Piros",
					"Z\u00f6ld",
					"S\u00e1rga",
					"Barna",
					"Lila",
					"R\u00f3zsasz\u00edn",
					"Narancss\u00e1rga"
				]
			},
			{
				"label": "Fut&aacute;sadat:",
				"name": "mileage"
			},
			{
				"label": "Rendsz&aacute;m:",
				"name": "license"
			},
			{
				"label": "Alv&aacute;zsz&aacute;m:",
				"name": "vin"
			}
		]
	} );

	var table = $('#vehicles').DataTable( {
		ajax: 'php/table.vehicles.php',
		columns: [
			{
				"data": "prodyear"
			},
			{
				"data": "type"
			},
			{
				"data": "engine"
			},
			{
				"data": "ccm"
			},
			{
				"data": "fueltype"
			},
			{
				"data": "color"
			},
			{
				"data": "mileage"
			},
			{
				"data": "license"
			},
			{
				"data": "vin"
			}
		],
		select: true,
		lengthChange: false
	} );

	new $.fn.dataTable.Buttons( table, [
		{ extend: "create", editor: editor },
		{ extend: "edit",   editor: editor },
		{ extend: "remove", editor: editor }
	] );

	table.buttons().container()
		.appendTo( $('.col-md-6:eq(0)', table.table().container() ) );
} );

}(jQuery));

