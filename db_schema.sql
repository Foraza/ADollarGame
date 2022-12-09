use a_dollar_game;

CREATE TABLE IF NOT EXISTS players(
	id INT PRIMARY KEY AUTO_INCREMENT,
    nickname CHAR(3),
    score FLOAT,
    start_time TIME,
    end_time TIME,
    played_time TIME
);

INSERT INTO players (id, nickname, score, start_time, end_time, played_time) VALUES (
	1,
	'DAN',
    0.15,
    current_time(),
    current_time(),
    current_time()
);

SELECT * FROM players;