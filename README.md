# Vinyl record exchanger

Record exchange platform: application that allows users to contribute their records to the common pool for others to rent or own. There would be an inventory, purchases and rentals, etc.

## Project overview 

0. The *community* consists of *members* who showcase, trade, and exchange their vinyl *records*.
0. The community *pool* consists of members' records marked for sale or for rent.
0. Every community member must have (register) an *account* to participate. 
0. Each member has an *account balance (wallet)* containing the user's *credits (currency, dollars)* allowing him or her to purchase or rent records from the community pool. 
0. Each new member is assigned 10 credits (community reward) upon joining the community. 
0. Each member can add credits to or withdraw credits from their account as necessary. [I will need Andrew's input on how to build this feature properly.]
0. The minimum amount for adding and withdrawing credits is 20 credits.
0. Each member must build his or her *collection* of records. 
0. Members can trade records with other members; members can also add to their collections by buying from external sources (brick-and-mortar record stores). 
0. Members can loan records to or rent records from other members. 
0. Upon completion, buyer and seller must rate transaction based on a 5-star rating describing overall experience.
0. Any record in collection marked as *for sale* or *for rent* is placed in the respective list in the community pool. 
0. The community pool displays all records marked for sale and for rent for all members. The pool view can be filtered (for sale only, for rent only) and sorted (a-z, z-a, newest to oldest, oldest to newest). [And perhaps by price.]
0. Records marked for sale must have sale prices. The sale price is charged one time, and the record is transferred to the new member's (buyer) collection.
0. Records marked for rent must have rental fees. The rental fee is charged every day from the start of rental until its end. [I'm not yet positive how to represent time in this app. I think it should work in real time, but I might compress the day to a few minutes for more efficient demonstrations. 
0. Each record must have an album artist, album title, track list, release date, musical genre, record format, side A speed (16.7, 33.3, 45, or 78 rpm), side B speed, record condition, sleeve condition, and special remarks.
0. Each track in the tracklist must contain the track title, track length (duration), the side (A or B), and the number (1, 2, 3, etc.)
0. Each member must have account, wallet, collection, and rating.

## Class and object overview

0. *Member* is an individual who has an established account in the community.
0. *Member id* is the unique identifier of a member in the community.
0. *Full name* is the combination of the first and last name user enters when registering an account in the community.
0. *Username* is the name existing members use to log into their account in the app. 
0. *Password* is a word used in conjunction with username when logging in which prevents unauthorized account access by guessing usernames in the app.
0. *Community* is the list of all community members. It is used to identify existing members using the app over multiple sessions.
0. ~~*Credit* is the currency used for all transactions within the app. Credits are assigned the decimal type with rounding to two digits.~~ 
0. *Wallet* is the container which stores and updates the member's balances in credits. 
0. *Rating* is the average of all ratings received as a buyer or seller. 
0. *Collection* is the list of a member's vinyl records. Records marked for sale or for rent are part of collection until they change owner. 
0. *Record* is a virtual representation of a physical record owned by a member and showcased in the member's collection. 
0. *Record id* is the unique record identifier.
0. *Sale price* is the price set when a member chooses to mark the record for sale. Records that aren't for sale have *null* as the value.
0. *Rent price* is the price set when a member chooses to mark the record for rent. Records that aren't for rent have *null* as the value.
0. *Album artist* is the name of the musician who created the album. 
0. *Album title* is the main title of the record. 
0. *Release date* is the date when the album has been released in public.
0. *Musical genre* is the generalized genre category that matches the record's musical style most closely.
0. *Record format* is the specification of the record's diameter (12-, 10-, 7-inch disc, or other for less common sizes).
0. *Record condition* is the physical condition of the vinyl disc. The possible values are *Mint*, *Near Mint*, *Good*, *Fair*, *Bad*.
0. *Sleeve condition* is identical to record condition.
0. *Side* is a single side of a record containing roughly a half of the album's contents. [Not sure I will need the side as a class, but let's keep it here for now.]
0. *Side (A or B) speed* is the specific playback speed for each side. 
0. *Track list* is the complete list of tracks on both sides.
0. *Track* is a basic component of a record. 
0. *Track title* is the main title of a track (song).
0. *Track length* is the time duration of a track.
0. *Track side* is the side assignment of a track (A or B)
0. *Track number* is the numeric index of the track on the specific side of a record. 

### Use case: new member

0. User launches the app.
0. App shows the title and brief intro.
0. App asks if the user is running the app for the first time.
0. User selects yes.
0. App verifies that the input is valid. [yes or no]
0. App runs a new account registration process.
 0. App creates a new member instance.
 0. App asks the user to enter the first name.
 0. User enters the first name.
 0. ~~App verifies that the input is valid. [2-20 characters, letters only]~~
 0. App asks the user to enter the last name.
 0. User enters the last name.
 0. ~~App verifies that the input is valid. [2-20 characters, letters, and spaces]~~
 0. App concatenates the first and last names into the full name.
 0. App asks the user to enter the username.
 0. User enters the username.
 0. ~~App verifies that input is valid. [5-20 characters, letters and numbers, must be unique]~~
 0. App asks the user to enter the password.
 0. ~~App verifies that the input is valid. [5-20 characters, letters and numbers]~~
 0. App checks member ids and assigns the first available id to the new member.
 0. App assigns the starting wallet balance of 10 credits to new member.
 0. App assigns the starting rating of 0 to new member.
 0. App assigns an empty collection list.
0. App offers the member the following options.
 0. View the collection list.
 0. Add a new record.
 0. Remove an existing record.
 0. Quit the application.
0. User chooses to quit the app.
0. App writes the member data to JSON file.

### Use case: existing member

0. User launches the app.
0. App shows the title and brief intro.
0. App asks if the user is running the app for the first time.
0. User selects no.
0. App verifies that the input is valid. [yes or no]
0. App reads the member data from JSON file.
0. App runs an existing user authentication process.
 0. App asks the user to enter the username.
 0. User enters the username.
 0. App checks if the input matches any usernames.
 0. App asks the user to enter the password.
 0. User enters the password. 
 0. App checks if the input matches the member's password.
0. App assigns the rest of the member's data.
0. App offers the member the following options.
 0. Add a new record.
 0. Remove an existing record.
 0. View the collection list.
 0. Quit the application.
0. User chooses to quit the app.
0. App writes the member data to JSON file.