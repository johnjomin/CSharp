# CSharp_TyreDeg_FormAndAPIRequest
 C# Tyre Degradatation Form and bit of Weather Open API exercise


# Exercise on Weather API

Fun challenge for me to do on Form application and Weather API

Calculating Tyre Degradatation point.

Formula for this is:
Point = (trackDegPoint x TrackTemp(in celsius)) / tyreCoefficient

- trackDegPoint: a value provided by the track degradation coefficients 
data.
- TrackTemp: the temperature in degrees Celsius.
- tyreCoefficient: a figure calculated by applying a percentage to the degradation 
coefficient provided by the tyre manufacturer.

Tyre Type: (Deg Coff)
- 75% Hard
- 80% Soft
- 90% Medium

Then final Result should be:
- The average all measured points.
- The mode: repeated more often
- The range: the max minus the min.

# The XML Format:
<Tyre>
	<Name></Name> 
	<Family></Family> 
	<Type><Type> 
	<Placement></Placement> 
	<DegradationCoefficient></DegradationCoefficient> 
</Tyre>