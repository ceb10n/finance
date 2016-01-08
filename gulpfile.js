var gulp = require('gulp'),
    clean = require('gulp-clean');


var destination = "./wwwroot/lib";
var source = "bower_components/**/*";

gulp.task('clean', function() {
     gulp.src(destination)
        .pipe(clean());
});

gulp.task('copy', ['clean'], function() {
    gulp.src(source)
        .pipe(gulp.dest(destination));
});