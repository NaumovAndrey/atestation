DROP DATABASE IF EXISTS human_friends;
CREATE DATABASE human_friends;
USE human_friends;

DROP TABLE IF EXISTS animals;
CREATE TABLE animals
(
    id           BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    kind_animals VARCHAR(50)
);

INSERT INTO `animals` (`id`, `kind_animals`)
values (1, 'cat'),
       (2, 'cat'),
       (3, 'dog'),
       (4, 'dog'),
       (5, 'hamster'),
       (6, 'hamster'),
       (7, 'horse'),
       (8, 'horse'),
       (9, 'camel'),
       (10, 'camel'),
       (11, 'donkey'),
       (12, 'donkey');

DROP TABLE IF EXISTS pets;
CREATE TABLE pets
(
    pet_id    BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    animal_id BIGINT UNSIGNED NOT NULL,
    FOREIGN KEY (animal_id) REFERENCES animals (id)
);

INSERT INTO `pets` (`pet_id`, `animal_id`)
values (1, 1),
       (2, 2),
       (3, 3),
       (4, 4),
       (5, 5),
       (6, 6);

DROP TABLE IF EXISTS pack_animals;
CREATE TABLE pack_animals
(
    pack_animal_id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    animal_id      BIGINT UNSIGNED NOT NULL,
    FOREIGN KEY (animal_id) REFERENCES animals (id)
);


INSERT INTO `pack_animals` (`pack_animal_id`, `animal_id`)
values (1, 7),
       (2, 8),
       (3, 9),
       (4, 10),
       (5, 11),
       (6, 12);

DROP TABLE IF EXISTS cat
;
CREATE TABLE cat

(
    cat_id    BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    animal_id BIGINT UNSIGNED NOT NULL,
    name      VARCHAR(50),
    commands  TEXT,
    birthday  DATE,
    FOREIGN KEY (animal_id) REFERENCES animals (id)
);

INSERT INTO `cat` (`cat_id`, `animal_id`, `name`, `commands`, `birthday`)
values (1, 1, 'Merss', 'сидеть: лежать', '2023-07-25'),
       (2, 2, 'Busya', 'сидеть: лежать', '2023-07-25');

DROP TABLE IF EXISTS dog
;
CREATE TABLE dog

(
    dog_id    BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    animal_id BIGINT UNSIGNED NOT NULL,
    name      VARCHAR(50),
    commands  TEXT,
    birthday  DATE,
    FOREIGN KEY (animal_id) REFERENCES animals (id)
);

INSERT INTO `dog` (`dog_id`, `animal_id`, `name`, `commands`, `birthday`)
values (1, 3, 'Nala', 'сидеть: лежать', '2023-07-25'),
       (2, 4, 'Джек', 'сидеть: лежать', '2023-07-25');

DROP TABLE IF EXISTS hamster
;
CREATE TABLE hamster

(
    hamster_id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    animal_id  BIGINT UNSIGNED NOT NULL,
    name       VARCHAR(50),
    commands   TEXT,
    birthday   DATE,
    FOREIGN KEY (animal_id) REFERENCES animals (id)
);

INSERT INTO `hamster` (`hamster_id`, `animal_id`, `name`, `commands`, `birthday`)
values (1, 5, 'Shura', 'сидеть: лежать', '2023-07-25'),
       (2, 6, 'Bim', 'сидеть: лежать', '2023-07-25');

DROP TABLE IF EXISTS horse
;
CREATE TABLE horse
(
    horse_id  BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    animal_id BIGINT UNSIGNED NOT NULL,
    name      VARCHAR(50),
    commands  TEXT,
    birthday  DATE,
    FOREIGN KEY (animal_id) REFERENCES animals (id)
);

INSERT INTO `horse` (`horse_id`, `animal_id`, `name`, `commands`, `birthday`)
values (1, 7, 'Jessica', 'сидеть: лежать', '2023-07-25'),
       (2, 8, 'Pigas', 'сидеть: лежать', '2023-07-25');

DROP TABLE IF EXISTS camel
;
CREATE TABLE camel
(
    camel_id  BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    animal_id BIGINT UNSIGNED NOT NULL,
    name      VARCHAR(50),
    commands  TEXT,
    birthday  DATE,
    FOREIGN KEY (animal_id) REFERENCES animals (id)
);

INSERT INTO `camel` (`camel_id`, `animal_id`, `name`, `commands`, `birthday`)
values (1, 9, 'Gosha', 'сидеть: лежать', '2023-07-25'),
       (2, 10, 'Gorbatyi', 'сидеть: лежать', '2023-07-25');

DROP TABLE IF EXISTS donkey
;
CREATE TABLE donkey
(
    donkey_id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    animal_id BIGINT UNSIGNED NOT NULL,
    name      VARCHAR(50),
    commands  TEXT,
    birthday  DATE,
    FOREIGN KEY (animal_id) REFERENCES animals (id)
);

INSERT INTO `donkey` (`donkey_id`, `animal_id`, `name`, `commands`, `birthday`)
values (1, 11, 'Oliver', 'сидеть: лежать', '2023-07-25'),
       (2, 12, 'Asi', 'сидеть: лежать', '2023-07-25');

DELETE camel
    , pack_animals, animals
FROM camel

         JOIN pack_animals
         JOIN animals
WHERE camel
          .animal_id = pack_animals.animal_id
  AND camel
          .animal_id = animals.id;


SELECT horse_id, NULL AS donkey_id, animal_id, name, commands, birthday
FROM horse

UNION
SELECT NULL AS horse_id, donkey_id, animal_id, name, commands, birthday
FROM donkey;

DROP TABLE IF EXISTS young_animals;
CREATE TABLE young_animals
SELECT animals.*,
       cat
           .name,
       TIMESTAMPDIFF(MONTH, birthday, NOW()) AS age
FROM cat
         LEFT JOIN animals ON animals.id = cat
    .animal_id
WHERE TIMESTAMPDIFF(MONTH, birthday, NOW()) < 37
  AND TIMESTAMPDIFF(MONTH, birthday, NOW()) > 11
UNION
SELECT animals.*,
       dog
           .name,
       TIMESTAMPDIFF(MONTH, birthday, NOW()) AS age
FROM dog

         LEFT JOIN animals ON animals.id = dog
    .animal_id
WHERE TIMESTAMPDIFF(MONTH, birthday, NOW()) < 37
  AND TIMESTAMPDIFF(MONTH, birthday, NOW()) > 11
UNION
SELECT animals.*,
       hamster
           .name,
       TIMESTAMPDIFF(MONTH, birthday, NOW()) AS age
FROM hamster


         LEFT JOIN animals ON animals.id = hamster
    .animal_id
WHERE TIMESTAMPDIFF(MONTH, birthday, NOW()) < 37
  AND TIMESTAMPDIFF(MONTH, birthday, NOW()) > 11
UNION
SELECT animals.*,
       horse
           .name,
       TIMESTAMPDIFF(MONTH, birthday, NOW()) AS age
FROM horse

         LEFT JOIN animals ON animals.id = horse
    .animal_id
WHERE TIMESTAMPDIFF(MONTH, birthday, NOW()) < 37
  AND TIMESTAMPDIFF(MONTH, birthday, NOW()) > 11
UNION
SELECT animals.*,
       name,
       TIMESTAMPDIFF(MONTH, birthday, NOW()) AS age
FROM donkey

         LEFT JOIN animals ON animals.id = donkey
    .animal_id
WHERE TIMESTAMPDIFF(MONTH, birthday, NOW()) < 37
  AND TIMESTAMPDIFF(MONTH, birthday, NOW()) > 11;

SELECT animals.id,
       cat
           .*,
       dog
           .*,
       hamster
           .*,
       horse
           .*,
       donkey
           .*
FROM animals
         LEFT JOIN cat
                   ON animals.id = cat
                       .animal_id
         LEFT JOIN dog
                   ON animals.id = dog
                       .animal_id
         LEFT JOIN hamster
                   ON animals.id = hamster
                       .animal_id
         LEFT JOIN horse
                   ON animals.id = horse
                       .animal_id
         LEFT JOIN donkey
                   ON animals.id = donkey
                       .animal_id;