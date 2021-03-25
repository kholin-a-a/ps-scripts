function CreateBy-Template {
    param (
        [string]$TemplateName,
        [string]$Name,
        [string]$TemplatePath = "$PSScriptRoot\templates"
    )

    if (-not $TemplateName) {
        throw "TemplateName is required"
    }

    if (-not $Name) {
        throw "Name is required"
    }

    Get-ChildItem $TemplatePath\$TemplateName* |
        ForEach {
            Get-Content $_ |
                Escape-Characters |
                    ForEach { Invoke-Expression "`"$($_)`""} |
                        Set-Content "$Name$($_.Extension)"
        }
}

function Escape-Characters {
    param (
        [Parameter(ValueFromPipeline)]
        $Text
    )

    Process {
        $Text -replace '"', '`"'
    }
}

function CebabToCamelCase {
    param (
        [string]$str
    )

    $regex = [Regex]"-([a-zA-Z])"

    $evaluator = {
        param (
            $match
        )

        "$($match.Groups[1].Value)".ToUpper()
    }

    $str.Substring(0, 1).ToUpper() + $regex.Replace($str.Substring(1), $evaluator)
}
