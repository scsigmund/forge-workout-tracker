User: id, name, email, username, password_hash, date_of_birth, gender, phone
Workout: id, start_datetime, end_datetime, user_id
Set: id, workout_id => Workout, exercise_id => Exercise, set_order, reps, weight(optional)
Exercise: id, name, muscle_group, instructions

set_order tells us the full workout sequence so it can handle supersets without additional code.
weight is optional for bodyweight movements.
passwords always stored as hash.

# TODO decide int vs GUID for ids before building.

# Branch test: editing on feature/about-section
