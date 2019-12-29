QUEST_SCENARIO1 = {
	title = 'IDS_PROPQUEST_SCENARIO_INC_000001',
	character = 'MaFl_Geron',
	end_character = '',
	start_requirements = {
		min_level = 15,
		max_level = 129,
		job = { 'JOB_VAGRANT', 'JOB_MERCENARY', 'JOB_ACROBAT', 'JOB_ASSIST', 'JOB_MAGICIAN', 'JOB_KNIGHT', 'JOB_BLADE', 'JOB_JESTER', 'JOB_RANGER', 'JOB_RINGMASTER', 'JOB_BILLPOSTER', 'JOB_PSYCHIKEEPER', 'JOB_ELEMENTOR', 'JOB_KNIGHT_MASTER', 'JOB_BLADE_MASTER', 'JOB_JESTER_MASTER', 'JOB_RANGER_MASTER', 'JOB_RINGMASTER_MASTER', 'JOB_BILLPOSTER_MASTER', 'JOB_PSYCHIKEEPER_MASTER', 'JOB_ELEMENTOR_MASTER', 'JOB_KNIGHT_HERO', 'JOB_BLADE_HERO', 'JOB_JESTER_HERO', 'JOB_RANGER_HERO', 'JOB_RINGMASTER_HERO', 'JOB_BILLPOSTER_HERO', 'JOB_PSYCHIKEEPER_HERO', 'JOB_ELEMENTOR_HERO' },
		previous_quest = '',
	},
	rewards = {
		gold = 21000,
	},
	end_conditions = {
		items = {
			{ id = 'II_SYS_SYS_QUE_TESTIMONY', quantity = 1, sex = 'Any', remove = false },
			{ id = 'II_SYS_SYS_QUE_MOONPAPER', quantity = 1, sex = 'Any', remove = false },
			{ id = 'II_SYS_SYS_QUE_SNAKEBONE', quantity = 1, sex = 'Any', remove = false },
		},
	},
	dialogs = {
		begin = {
			'IDS_PROPQUEST_SCENARIO_INC_000002',
			'IDS_PROPQUEST_SCENARIO_INC_000003',
			'IDS_PROPQUEST_SCENARIO_INC_000004',
			'IDS_PROPQUEST_SCENARIO_INC_000005',
			'IDS_PROPQUEST_SCENARIO_INC_000006',
		},
		begin_yes = {
			'IDS_PROPQUEST_SCENARIO_INC_000007',
		},
		begin_no = {
			'IDS_PROPQUEST_SCENARIO_INC_000008',
		},
		completed = {
			'IDS_PROPQUEST_SCENARIO_INC_000009',
		},
		not_finished = nil,
	}
}
