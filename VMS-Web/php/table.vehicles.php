<?php
// DataTables PHP library and database connection
include( "lib/DataTables.php" );

// Alias Editor classes so they are easy to use
use
	DataTables\Editor,
	DataTables\Editor\Field,
	DataTables\Editor\Format,
	DataTables\Editor\Mjoin,
	DataTables\Editor\Options,
	DataTables\Editor\Upload,
	DataTables\Editor\Validate,
	DataTables\Editor\ValidateOptions;

// Build our Editor instance and process the data coming from _POST
Editor::inst( $db, 'vehicles', 'vehid' )
	->fields(
		Field::inst( 'owner' )
			->set( false ),
		Field::inst( 'prodyear' )
			->validator( Validate::notEmpty() )
			->validator( Validate::minMaxNum( 1000, 2999 ) ),
		Field::inst( 'type' )
			->validator( Validate::notEmpty() )
			->validator( Validate::maxLen( 255 ) ),
		Field::inst( 'engine' )
			->validator( Validate::notEmpty() ),
		Field::inst( 'ccm' )
			->validator( Validate::notEmpty() )
			->validator( Validate::minMaxNum( 1, 99999 ) ),
		Field::inst( 'fueltype' )
			->validator( Validate::notEmpty() ),
		Field::inst( 'color' )
			->validator( Validate::notEmpty() ),
		Field::inst( 'mileage' )
			->validator( Validate::notEmpty() )
			->validator( Validate::maxLen( 7 ) ),
		Field::inst( 'license' )
			->validator( Validate::notEmpty() )
			->validator( Validate::minMaxLen( 6, 6 ) ),
		Field::inst( 'vin' )
			->validator( Validate::notEmpty() )
			->validator( Validate::minMaxLen( 17, 17 ) )
	)
	->process( $_POST )
	->json();
