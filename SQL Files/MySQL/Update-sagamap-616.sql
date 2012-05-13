ALTER TABLE `char` ADD INDEX(`name`);
ALTER TABLE `char` ADD INDEX(`account_ID`);
ALTER TABLE `inventory` ADD INDEX(`charID`);
ALTER TABLE `joblevel` ADD INDEX(`charID`,`job`);
ALTER TABLE `mail` ADD INDEX(`receiver`);
ALTER TABLE `mail` ADD INDEX(`sender`);
ALTER TABLE `mapinfo` ADD INDEX(`charID`,`map`);
ALTER TABLE `quest` ADD INDEX(`charID`);
ALTER TABLE `shortcuts` ADD INDEX(`charID`);
ALTER TABLE `skills` ADD INDEX(`charID`);
ALTER TABLE `weapon` ADD INDEX (`charID`);
ALTER TABLE `char` CHANGE `online` `online` TINYINT( 3 ) UNSIGNED NOT NULL DEFAULT '0';
ALTER TABLE `char` ADD `muted` TINYINT UNSIGNED NOT NULL DEFAULT '0' ;