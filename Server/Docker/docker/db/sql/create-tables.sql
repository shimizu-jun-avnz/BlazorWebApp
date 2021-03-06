---- drop ----
DROP TABLE IF EXISTS `employee`;
DROP TABLE IF EXISTS `general_code_master`;
DROP TABLE IF EXISTS `job_rank_code_master`;
DROP TABLE IF EXISTS `department_code_master`;
DROP TABLE IF EXISTS `division_code_master`;

---- create ----
create table IF not exists `employee`
(
 `emp_no`               VARCHAR(20) NOT NULL,
 `name`                 VARCHAR(20) NOT NULL,
 `picture_file_name`    VARCHAR(200) NOT NULL,
 `gender`               INTEGER NOT NULL,
 `birth_day`            DATE,
 `enter_day`            DATE,
 `retirement_day`       DATE,
 `job_rank`             INTEGER NOT NULL,
 `belongs_department`   INTEGER NOT NULL,
 `belongs_division`     INTEGER NOT NULL,
 `created_at`           Datetime DEFAULT NULL,
 `updated_at`           Datetime DEFAULT NULL,
  PRIMARY KEY (`emp_no`)
) DEFAULT CHARSET=utf8 COLLATE=utf8_bin;


create table IF not exists `general_code_master`
(
 `code_type`           INTEGER NOT NULL,
 `code_id`             INTEGER NOT NULL,
 `name`                VARCHAR(100) NOT NULL,
 `created_at`          Datetime DEFAULT NULL,
 `updated_at`          Datetime DEFAULT NULL,
  PRIMARY KEY (`code_type`, `code_id` )
) DEFAULT CHARSET=utf8 COLLATE=utf8_bin;


create table IF not exists `department_code_master`
(
 `department_id`       INTEGER NOT NULL,
 `department_name`     VARCHAR(100) NOT NULL,
 `created_at`          Datetime DEFAULT NULL,
 `updated_at`          Datetime DEFAULT NULL,
  PRIMARY KEY (`department_id` )
) DEFAULT CHARSET=utf8 COLLATE=utf8_bin;


create table IF not exists `division_code_master`
(
 `division_id`         INTEGER NOT NULL,
 `division_name`       VARCHAR(100) NOT NULL,
 `created_at`          Datetime DEFAULT NULL,
 `updated_at`          Datetime DEFAULT NULL,
  PRIMARY KEY (`division_id` )
) DEFAULT CHARSET=utf8 COLLATE=utf8_bin;


create table IF not exists `job_code_master`
(
 `job_id`         INTEGER NOT NULL,
 `job_name`       VARCHAR(100) NOT NULL,
 `created_at`          Datetime DEFAULT NULL,
 `updated_at`          Datetime DEFAULT NULL,
  PRIMARY KEY (`job_id` )
) DEFAULT CHARSET=utf8 COLLATE=utf8_bin;


---- insert ----
---- employee -----
INSERT INTO employee(emp_no,name,picture_file_name,gender,birth_day,enter_day,retirement_day,job_rank,belongs_department,belongs_division,created_at,updated_at)
 VALUES ('00163','????????????','images/photo/00163.jpg',1,'19781107','20060701',null,7,3,3,CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO employee(emp_no,name,picture_file_name,gender,birth_day,enter_day,retirement_day,job_rank,belongs_department,belongs_division,created_at,updated_at)
 VALUES ('00219','???????????????','images/photo/00219.jpg',1,'19000101','20000101',null,7,2,3,CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO employee(emp_no,name,picture_file_name,gender,birth_day,enter_day,retirement_day,job_rank,belongs_department,belongs_division,created_at,updated_at)
 VALUES ('00049','???????????????','images/photo/00049.jpg',1,'19000101','20000101',null,7,1,3,CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO employee(emp_no,name,picture_file_name,gender,birth_day,enter_day,retirement_day,job_rank,belongs_department,belongs_division,created_at,updated_at)
 VALUES ('00304','???????????????','images/photo/00304.jpg',1,'19000101','20000101',null,7,3,2,CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO employee(emp_no,name,picture_file_name,gender,birth_day,enter_day,retirement_day,job_rank,belongs_department,belongs_division,created_at,updated_at)
 VALUES ('00194','??????????????????','images/photo/00194.jpg',1,'19000101','20000101',null,6,3,4,CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO employee(emp_no,name,picture_file_name,gender,birth_day,enter_day,retirement_day,job_rank,belongs_department,belongs_division,created_at,updated_at)
 VALUES ('00176','????????????','images/photo/00176.jpg',1,'19000101','20000101',null,6,1,1,CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
 
---- general_code_master -----
INSERT INTO general_code_master(code_type,code_id,name,created_at,updated_at)
 VALUES (1,1,'???',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO general_code_master(code_type,code_id,name,created_at,updated_at)
 VALUES (1,2,'???',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO general_code_master(code_type,code_id,name,created_at,updated_at)
 VALUES (1,3,'?????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);

---- department_code_master -----
INSERT INTO department_code_master(department_id,department_name,created_at,updated_at)
 VALUES (1,'?????????????????????????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO department_code_master(department_id,department_name,created_at,updated_at)
 VALUES (2,'?????????????????????????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO department_code_master(department_id,department_name,created_at,updated_at)
 VALUES (3,'????????????????????????????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO department_code_master(department_id,department_name,created_at,updated_at)
 VALUES (4,'?????????????????????????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO department_code_master(department_id,department_name,created_at,updated_at)
 VALUES (5,'?????????????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO department_code_master(department_id,department_name,created_at,updated_at)
 VALUES (6,'??????????????????????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO department_code_master(department_id,department_name,created_at,updated_at)
 VALUES (7,'?????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);

---- division_code_master -----
INSERT INTO division_code_master(division_id,division_name,created_at,updated_at)
 VALUES (1,'??????????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO division_code_master(division_id,division_name,created_at,updated_at)
 VALUES (2,'??????????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO division_code_master(division_id,division_name,created_at,updated_at)
 VALUES (3,'??????????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO division_code_master(division_id,division_name,created_at,updated_at)
 VALUES (4,'??????????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
 
 ---- job_code_master -----
INSERT INTO job_code_master(job_id,job_name,created_at,updated_at)
 VALUES (1,'???????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO job_code_master(job_id,job_name,created_at,updated_at)
 VALUES (2,'??????????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO job_code_master(job_id,job_name,created_at,updated_at)
 VALUES (3,'??????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO job_code_master(job_id,job_name,created_at,updated_at)
 VALUES (4,'???????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO job_code_master(job_id,job_name,created_at,updated_at)
 VALUES (5,'??????????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO job_code_master(job_id,job_name,created_at,updated_at)
 VALUES (6,'???????????????????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO job_code_master(job_id,job_name,created_at,updated_at)
 VALUES (7,'????????????????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO job_code_master(job_id,job_name,created_at,updated_at)
 VALUES (8,'????????????????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
INSERT INTO job_code_master(job_id,job_name,created_at,updated_at)
 VALUES (9,'??????????????????',CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);

 