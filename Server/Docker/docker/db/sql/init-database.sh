#!/usr/bin/env bash
mysql -u docker -pblazor33252XL blazor < "/docker-entrypoint-initdb.d/create-tables.sql"