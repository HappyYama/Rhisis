QUEST_SCE_MDRIGALTEACHER1 = {
	title = 'IDS_PROPQUEST_SCENARIO_INC_000689',
	character = 'MaDa_Icinis',
	end_character = 'MaFl_Elic',
	start_requirements = {
		min_level = 91,
		max_level = 129,
		job = { 'JOB_VAGRANT', 'JOB_MERCENARY', 'JOB_ACROBAT', 'JOB_ASSIST', 'JOB_MAGICIAN', 'JOB_KNIGHT', 'JOB_BLADE', 'JOB_JESTER', 'JOB_RANGER', 'JOB_RINGMASTER', 'JOB_BILLPOSTER', 'JOB_PSYCHIKEEPER', 'JOB_ELEMENTOR', 'JOB_KNIGHT_MASTER', 'JOB_BLADE_MASTER', 'JOB_JESTER_MASTER', 'JOB_RANGER_MASTER', 'JOB_RINGMASTER_MASTER', 'JOB_BILLPOSTER_MASTER', 'JOB_PSYCHIKEEPER_MASTER', 'JOB_ELEMENTOR_MASTER', 'JOB_KNIGHT_HERO', 'JOB_BLADE_HERO', 'JOB_JESTER_HERO', 'JOB_RANGER_HERO', 'JOB_RINGMASTER_HERO', 'JOB_BILLPOSTER_HERO', 'JOB_PSYCHIKEEPER_HERO', 'JOB_ELEMENTOR_HERO' },
		previous_quest = '',
	},
	rewards = {
		gold = 0,
	},
	end_conditions = {
	},
	dialogs = {
		begin = {
			'IDS_PROPQUEST_SCENARIO_INC_000690',
			'IDS_PROPQUEST_SCENARIO_INC_000691',
			'IDS_PROPQUEST_SCENARIO_INC_000692',
		},
		begin_yes = {
			'IDS_PROPQUEST_SCENARIO_INC_000693',
		},
		begin_no = {
			'IDS_PROPQUEST_SCENARIO_INC_000694',
		},
		completed = {
			'IDS_PROPQUEST_SCENARIO_INC_000695',
			'IDS_PROPQUEST_SCENARIO_INC_000696',
		},
		not_finished = {
			'IDS_PROPQUEST_SCENARIO_INC_000776',
		},
	}
}
