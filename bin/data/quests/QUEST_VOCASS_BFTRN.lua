QUEST_VOCASS_BFTRN = {
	title = 'IDS_PROPQUEST_INC_000723',
	character = 'MaFl_Elic',
	start_requirements = {
		min_level = 15,
		max_level = 15,
		job = { 'JOB_VAGRANT' },
	},
	rewards = {
		gold = 1500,
	},
	dialogs = {
		begin = {
			'IDS_PROPQUEST_INC_000724',
			'IDS_PROPQUEST_INC_000725',
			'IDS_PROPQUEST_INC_000726',
		},
		begin_yes = {
			'IDS_PROPQUEST_INC_000727',
		},
		begin_no = {
			'IDS_PROPQUEST_INC_000728',
		},
		completed = {
			'IDS_PROPQUEST_INC_000729',
			'IDS_PROPQUEST_INC_000730',
		},
		not_finished = {
			'IDS_PROPQUEST_INC_000731',
		},
	}
}
