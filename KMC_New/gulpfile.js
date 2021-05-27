const gulp = require('gulp');
let cleanCSS = require('gulp-clean-css');
var uglify = require('gulp-uglify');
var pipeline = require('readable-stream').pipeline;

gulp.task('message', function (cb) {
    console.log('Gulp is running........');
    cb();
})

gulp.task('minify-css', () => {
    return gulp.src('css/*.css')
        .pipe(cleanCSS({ compatibility: 'ie8' }))
        .pipe(gulp.dest('GulpFiles/minify-css'));
});

gulp.task('uglify-js', function () {
    return pipeline(
        gulp.src('Scripts/custom/*.js'),
        uglify(),
        gulp.dest('Uglify-JS')
    );
});