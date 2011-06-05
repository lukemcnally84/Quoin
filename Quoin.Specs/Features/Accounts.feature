#
# Accounts represent the physical accounts that a user has with various institutions.
# 
# Accounts come in a number of types:
#  * Current
#  * Savings (ISAs, bonds, etc)
#  * Loans (mortgages, personal, hire-purchase, etc)
#  * Credit Cards
#  * 

Feature: Accounts
	In order to manage my finances
	As a user
	I want to be able to create, edit and delete Accounts

Scenario: Add an Account
	Given I have logged in
	And I am on the Home page
	When I press Add Account
	Then I should see the New Account page
