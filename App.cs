/* App.css */
body {
	font-family: Arial, sans-serif;
	margin: 0;
	padding: 0;
	background-color: #ffffff;
}

.App-header {
	background-color: #6cc24a;
	padding: 20px;
	color: white;
	text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.2);
	text-align: center;
}

.App-main {
	display: flex;
	flex-wrap: wrap;
	flex-direction: column;
	align-items: center;
	justify-content: center;
	padding: 20px;
}

/* Search Component */
.search-bar {
	width: 100%;
	max-width: 400px;
	margin: 0 auto;
	display: flex;
	align-items: center;
	background-color: white;
	border-radius: 20px;
	box-shadow: 0px 4px 8px rgba(0, 0, 0, 0.1);
	padding: 5px 10px;
}

.search-bar input {
	flex: 1;
	padding: 10px;
	border: none;
	border-radius: 5px;
	font-size: 16px;
	background-color: #ffffff;
	transition: background-color 0.3s ease-in-out;
}

.search-bar input:focus {
	outline: none;
	background-color: #ffffff;
}

.search-icon {
	font-size: 1.2rem;
	margin-right: 10px;
	color: #6cc24a;
}

/* Product Display */
.product-list {
	flex: 2;
	display: flex;
	gap: 20px;
}

.product {
	background-color: rgb(255, 245, 245);
	border: 1px solid #1b4e1f;
	border-radius: 10%;
	padding: 10px 60px;
	text-align: center;
	width: 33%;
	transition: transform 0.2s ease-in-out;
	cursor: pointer;
	overflow: hidden;
	position: relative;
}

.product:hover {
	transform: translateY(-5px) scale(1.03);
}

.product img {
	max-width: 150px;
	/* Increased image size */
	height: auto;
	margin-bottom: 10px;
	border-radius: 50%;
	box-shadow: 0px 6px 12px rgba(0, 0, 0, 0.2);
	/* Enhanced box shadow */
	transition: transform 0.3s ease-in-out, box-shadow 0.3s ease-in-out;
	/* Added box shadow transition */
}

.product:hover img {
	transform: scale(1.1);
	z-index: 1;
	box-shadow: 0px 8px 16px rgba(0, 0, 0, 0.3);
	/* Enhanced box shadow on hover */
}

.product h2 {
	font-size: 1.5rem;
	margin: 10px 0;
	color: #323754;
}

.product p {
	font-size: 1.1rem;
	color: #777;
	margin: 5px 0;
}

/* Cart Checkout */
.cart {
	flex: 1;
	min-width: 300px;
	margin-top: 3%;
	background-color: #fff9e6;
	border: 2px solid #193d10;
	border-radius: 20px;
	padding: 10px 20px;
	box-shadow: 0px 10px 20px rgba(0, 0, 0, 0.1);
	display: none;
	position: sticky;
	top: 20px;
}

.cart.active {
	display: block;
}

.cart h2 {
	font-size: 1.8rem;
	color: #323754;
	margin-top: 0;
	text-align: center;
}

.cart ul {
	list-style: none;
	padding: 0;
	margin: 0;
}

.cart-item {
	display: flex;
	flex-direction: column;
	justify-content: space-between;
	align-items: center;
	margin: 15px 0;
	padding: 10px;
	border-bottom: 1px solid #e0e0e0;
}

.cart-item .item-image img {
	max-width: 90px;
	height: auto;
	margin-right: 20px;
	border-radius: 50%;
	box-shadow: 0px 4px 8px rgba(0, 0, 0, 0.1);
	transition: transform 0.3s ease-in-out;
}

.cart-item .item-image img:hover {
	transform: scale(1.1);
}

.cart-item .item-details {
	flex: 1;
	display: inline;
}

.cart-item h3 {
	display: inline;
	font-size: 1.4rem;
	margin: 0;
	color: #323754;
}

.cart-item p {
	font-size: 1.1rem;
	color: #777;
	margin: 5px 0;
}

.cart-item .item-actions {
	display: flex;
	flex-direction: row;
	align-items: center;
}

.cart-item .item-actions button {
	background-color: #6cc24a;
	border: none;
	color: white;
	padding: 8px 15px;
	border-radius: 20px;
	cursor: pointer;
	transition: background-color 0.3s ease-in-out;
	font-size: 1rem;

}

.cart-item .item-actions button:hover {
	background-color: #449e30;
}

.cart-item .quantity {
	display: flex;
	flex-direction: row;
	margin-left: 15px;
	font-size: 1rem;
	color: #323754;
}

.cart .total {
	font-size: 1.4rem;
	margin: 20px 0;
	text-align: right;
	color: #323754;
}

.cart .checkout-button {
	background-color: #6cc24a;
	border: none;
	color: white;
	padding: 10px 15px;
	border-radius: 20px;
	cursor: pointer;
	transition: background-color 0.3s ease-in-out;
	font-size: 1.2rem;
	float: left;
}

.cart .checkout-button:hover {
	background-color: #449e30;
}

.checkout-message {
	font-size: 1.4rem;
	margin-top: 30px;
	color: #6cc24a;
	text-align: center;
}

.no-results,
.empty-cart {
	text-align: center;
	font-size: 1.4rem;
	color: #777;
	margin-top: 20px;
}

@media screen and (max-width: 768px) {
	.App-main {
		flex-direction: column;
		align-items: center;
	}

	.product-list {
		width: 100%;
		margin-bottom: 5px;
	}

	.product {
		width: 50%;
	}

	.cart {
		min-width: unset;
		margin-top: 30px;
	}
}

.add-to-cart-button {
	background-color: #6cc24a;
	border: none;
	color: white;
	padding: 8px 15px;
	border-radius: 20px;
	cursor: pointer;
	transition: background-color 0.3s ease-in-out;
	font-size: 1rem;
}

.add-to-cart-button:hover {
	background-color: #449e30;
}

.item-info {
	display: flex;
	flex-direction: row;
}

.item-details {
	margin-top: 4%;
}

.item-actions .quantity p {
	margin: 10% 10%;
}

.product-list {
	padding-bottom: 5%;
	border-bottom: 2px solid green;
}

.checkout-section {
	float: right;
	margin: 0;
}

.checkout-section .checkout-button {
	background-color: #323754;
}

.checkout-section .checkout-button:hover {
	background-color: #4c5cb6;
}
