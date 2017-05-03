function gradsToDegrees([grads]) {
	let degrees = grads * 0.9;
	if (degrees < 0)
		return 360 + degrees;
	if(degrees > 360)
		return degrees % 360;
	return degrees % 360;
}
