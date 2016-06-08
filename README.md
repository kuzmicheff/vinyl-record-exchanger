# Vinyl record exchanger

Vinyl record exchanger in C#. This application enables a community of vinyl record aficionados to showcase their collections, trade or rent records, and browse the community pool for inspiration. 

This project should be equal or comparable to the default Humane Society engine. The following ideas have come up.

0. ~~Community beatbox sampler: application that allows users to record beatboxing samples on a virtual 8x8 pad (non-visual in the project version), listen to samples, contribute to projects, and export project files for DAW processing.~~
0. Record exchange platform: application that allows users to contribute their records to the common pool for others to rent or own. There would be an inventory, purchases and rentals, etc.
0. ~~Bakery order processing: application that allows placing bakery orders by selecting base items and their customizations from the bakery menu. Upon successful order placement, the customer and bakery staff would receive the order email, and customer would be charged a sale amount.~~

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

## Class overview

0. *Member* is an individual who has an established account in the community.
0. *Community* is the list of all community members. It is used to identify existing members using the app over multiple sessions.
0. *Credit* is the currency used for all transactions within the app. Credits are assigned the decimal type with rounding to two digits. 
0. *Wallet* is the container which stores and updates the member's balances in credits. 
0. *Rating* is the average of all ratings received as a buyer or seller. 
0. *Collection* is the list of a member's vinyl records. Records marked for sale or for rent are part of collection until they change owner. 
0. *Record* is a virtual representation of a physical record owned by a member and showcased in the member's collection. 
0. *Album artist* is the name of the musician who created the album. 
0. *Album title* is the main title of the record. 
0. *Track list* is the complete list of tracks on both sides.
0. *Release date* is the date when the album has been released in public.
0. *Musical genre* is the generalized genre category that matches the record's musical style most closely.
0. *Record format* is the specification of the record's diameter (12-, 10-, 7-inch disc, or other for less common sizes).
0. *Side* is a single side of a record containing roughly a half of the album's contents. [Not sure I will need the side as a class, but let's keep it here for now.]
0. *Side (A or B) speed* is the specific playback speed for each side. 
0. *Track* is a basic component of a record. 
0. *Track title* is the main title of a track (song).
0. *Track length* is the time duration of a track.
0. *Track side* is the side assignment of a track (A or B)
0. *Track number* is the numeric index of the track on the specific side of a record. 

## Development plan

0. ~~Create the Credit class~~ [Credit does not need to be set up as a class; it can be set up as a variable inside the Wallet class.]
0. Create the Wallet class
 0. Wallet has a balance which is a decimal amount in credits. 
 0. Credits can be deposited into wallet with the *depositCredits()* method.
 0. Credits can be withdrawn from wallet with the *withdrawCredits()* method. 
 0. The current account balance can be checked with *checkBalance()* method. 
0. Create the Member class
 0. Member has the following attributes: first name, last name, username, password, rating, wallet, and collection (list). 
0. Create the Community class
0. Create the Collection class