export interface User {
	firstName : string,
	lastName: string,
	age?: number, // optional
	address?: {
		street? : string,
		city?: string,
		state?: string
	},
	image?: string,
	isActive? : boolean,
	balance?: number,
	registered?: any
}

// This is for testing form and event (fifthExample)
export interface User2 {
	firstName : string,
	lastName: string,
	age?: number, // optional
	address?: {
		street? : string,
		city?: string,
		state?: string
	},
	isActive? : boolean,
	registered?: any,
	hide? : boolean
}

export interface User3 {
	firstName : string,
	lastName: string,
	email: string,
	isActive? : boolean,
	registered?: any,
	hide? : boolean
}