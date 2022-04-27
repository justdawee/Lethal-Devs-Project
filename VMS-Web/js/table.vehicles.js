
/*
 * Editor client script for DB table vehicles
 * Created by http://editor.datatables.net/generator
 */
var realname = "<?php echo json_encode($_SESSION['realname']) ?>;"

(function($){

$(document).ready(function() {

	var editor = new $.fn.dataTable.Editor( {
		ajax: 'php/table.vehicles.php',
		table: '#vehicles',
		fields: [
			{
				"label": "Tulaj:",
				"name": "owner",
				"type": "hidden",
			},
			{
				"label": "Évjárat:",
				"name": "prodyear"
			},
			{
				"label": "Típus:",
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
					"Egyéb"
				]
			},
			{
				"label": "Köbcenti:",
				"name": "ccm"
			},
			{
				"label": "Üzemanyag:",
				"name": "fueltype",
				"type": "select",
				"options": [
					"Benzin",
					"Dízel",
					"Elektromos",
					"Benzin + Gáz",
					"Hibrid (Benzin)",
					"Hibrid (Dízel)",
					"Hidrogéncella",
					"Egyéb"
				]
			},
			{
				"label": "Sz&iacute;n:",
				"name": "color",
				"type": "select",
				"options": [
					"Fehér",
					"Fekete",
					"Szürke",
					"Ezüst",
					"Kék",
					"Piros",
					"Zöld",
					"Sárga",
					"Barna",
					"Lila",
					"Rózsaszín",
					"Narancssárga"
				]
			},
			{
				"label": "Futásadat:",
				"name": "mileage"
			},
			{
				"label": "Rendszám:",
				"name": "license"
			},
			{
				"label": "Alvázszám:",
				"name": "vin"
			}
		],
		i18n: {
            create: {
                button: "Új",
                title:  "Jármű hozzáadása",
                submit: "Hozzáadás"
            },
            edit: {
                button: "Módosítás",
                title:  "Jármű módosítása",
                submit: "Szerkesztés"
            },
            remove: {
                button: "Törlés",
                title:  "Törlés",
                submit: "Törlés",
                confirm: {
                    _: "Biztosan törölni szeretnéd ezt a %d db járművet?",
                    1: "Biztosan törölni szeretnéd ezt az 1 db járművet?"
                }
            },
            error: {
                system: "Váratlan hiba történt."
            }
        }
	} );

	var table = $('#vehicles').DataTable( {
		language: {
            processing:     "Feldolgozás...",
			search:         "Keresés:",
			lengthMenu:     "_MENU_ találat oldalanként",
			info:           "Találatok: _START_-től _END_-ig. Összesen: _TOTAL_",
			infoEmpty:      "Nulla találat",
			infoFiltered:   "(_MAX_ közül szűrve)",
			infoPostFix:    "",
			loadingRecords: "Betöltés...",
			zeroRecords:    "Nincs a keresésnek megfelelő találat",
			emptyTable:     "Nincs járműve az adatbázisban.",
			paginate: {
				first:      "Első",
				previous:   "Előző",
				next:       "Következő",
				last:       "Utolsó"
			},
			aria: {
				sortAscending:  ": aktiválja a növekvő rendezéshez",
				sortDescending: ": aktiválja a csökkenő rendezéshez"
			},
			select: {
				rows: {
					_: "%d jármű kiválasztva",
					1: "1 jármű kiválasztva"
				}
			}
        },
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

