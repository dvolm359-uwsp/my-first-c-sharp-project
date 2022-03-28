SHELL := /bin/bash

.PHONY: help
help:
	@printf "available targets -->\n\n"
	@cat Makefile | grep ".PHONY" | grep -v ".PHONY: _" | sed 's/.PHONY: //g'


.PHONY: _delete_zips
_delete_zips:
	rm -f *.zip


.PHONY: zips
zips: _delete_zips
	set -x && \
		for proj in *; do \
			if echo $${proj} | grep -q "Makefile"; then \
				echo "Skipping zipping Makefile"; \
			else \
				zip -9 -r $$(echo "Volm.David.CIS_340-01.$${proj}.$$(date +%Y-%m-%d).$$(git log | head -n 1 | head -c 15).zip" | sed 's/commit //g; s/ /_/g') "$${proj}"; \
			fi \
		done \
	;
